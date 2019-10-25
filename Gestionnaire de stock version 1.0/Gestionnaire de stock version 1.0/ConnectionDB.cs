using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_stock_version_1._0
{
    class ConnectionDB
    {
        private MySqlConnection connection;

        // Constructeur
        public ConnectionDB()
        {
            InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion

            // string connectionString = "SERVER=10.229.33.3; DATABASE=Gestionnaire; UID=Stephane; PASSWORD=Pa$$w0rd";
            string connectionString = "SERVER=127.0.0.1; DATABASE=Gestionnaire; UID=root; PASSWORD=LuanaKBL2612";
            connection = new MySqlConnection(connectionString);

        }
        //créer un objet fournisseur qui sera crée quand on appuye sur valider--> l'objet sera mis en parametre de Addsupplier
        public void OpenDB()
        {
            connection.Open();
        }
        public void CloseDB()
        {
            connection.Close();
        }

        /// <summary>
        /// Insertion des produits
        /// </summary>
        /// <param name="name"></param>
        /// <param name="categorie"></param>
        /// <returns></returns>
        public long InsertProduit(string name, int categorie)
        {
            string produit = "INSERT INTO products(Name,Categories_id) VALUES('" + name + "'," + categorie + ");";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(produit, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;

        }

        public void UpdateStatus(int id)
        {
            string updatestatus = "UPDATE CommandeLines SET Status = 1 WHERE id =" + id + ";";
            MySqlCommand cmd = new MySqlCommand(updatestatus, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Insert categories
        /// </summary>
        /// <param name="name"></param>
        public void InsertCategorie(string name)
        {
            string commande = "INSERT INTO Categories(Name) VALUES('" + name + "');";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Insertions des fournisseurs
        /// </summary>
        /// <param name="idproducts"></param>
        /// <param name="idsuppliers"></param>
        public void InsertProductsSuppliers(long idproducts, long idsuppliers)
        {
            string commande = "INSERT INTO Products_has_Suppliers(Products_id,Suppliers_id) VALUES(" + idproducts + "," + idsuppliers + ");";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Insertion des fournisseur 
        /// </summary>
        /// <param name="supplier"></param>
        public void AddSupplier(Supplier supplier)
        {
            try
            {
                // Ouverture de la connexion SQL
                connection.Open();
                
                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO suppliers (Firstname, Lastname, Company, City, NPA, Street, Email) VALUES (@Firstname, @Lastname, @Company, @City, @NPA, @Street, @Email)";

                // utilisation de l'objet contact passé en paramètre
                
                cmd.Parameters.AddWithValue("@Firstname",supplier.firstName );
                cmd.Parameters.AddWithValue("@Lastname", supplier.lastName);
                cmd.Parameters.AddWithValue("@Company", supplier.company);
                cmd.Parameters.AddWithValue("@City", supplier.city);
                cmd.Parameters.AddWithValue("@NPA", supplier.npa);
                cmd.Parameters.AddWithValue("@Street", supplier.street);
                cmd.Parameters.AddWithValue("@Email", supplier.email);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }

        public void InsertProduisHasCommandeLine(int quantity, int productsid, int unitiesid, string peremption, int status)
        {
            string commande;
            if (peremption != "")
            {
                commande = "INSERT INTO commandelines(Quantity,Products_id,Unities_id,Peremption,Status) VALUES(" + quantity + "," + productsid + "," + unitiesid + ",'" + peremption + "'," + status + ");";
            }
            else
            {
               commande = "INSERT INTO commandelines(Quantity,Products_id,Unities_id,Status) VALUES(" + quantity + "," + productsid + "," + unitiesid + "," + status + ");";
            }
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        public void DeletInStock(int idproduit)
        {
            string commande = "Delete From commandelines WHERE commandelines.id =" + idproduit + ";";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        public void UpdateProducts(int idproduit, string nomproduit, int idcategorie)
        {
            string commande = "UPDATE Products SET Name='"+nomproduit+"',Categories_id ="+ idcategorie + " WHERE id =" + idproduit + ";";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        public void UpdateCommandeLines(int id, int quantity, string date,  int idunities)
        {
            string commande = "UPDATE CommandeLines SET Quantity="+quantity+",Peremption='"+date+"',Unities_id="+idunities+" WHERE id ="+id+";";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Lire les Fournisseur
        /// </summary>
        /// <returns></returns>
        public List<Supplier> ReadFournisseur()
        {
            //Le problème que vous rencontrez est que vous démarrez une seconde MySqlCommandtout en lisant les données avec le DataReader. Le connecteur MySQL n'autorise qu'une requête simultanée. Vous devez lire les données dans une structure, puis fermer le lecteur, puis traiter les données. Malheureusement, vous ne pouvez pas traiter les données telles qu'elles sont lues si votre traitement implique d'autres requêtes SQL.
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Firstname,Lastname,id FROM suppliers";
            List<Supplier> listData = new List<Supplier>();
            MySqlDataReader dataReader1 = cmd.ExecuteReader();
            while (dataReader1.Read())
            {               
                string dataFirstanme = dataReader1["Firstname"].ToString();
                string dataLastnme = dataReader1["Lastname"].ToString();
                int dataId = (int)dataReader1["id"];
                Supplier fournisseurs = new Supplier(dataId, dataFirstanme, dataLastnme);
                listData.Add(fournisseurs);
            }

            return listData;


        }

        public List<Products> ReadProducts()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Name,id FROM Products";
            List<Products> listData = new List<Products>();
            MySqlDataReader dataReader1 = cmd.ExecuteReader();
            while (dataReader1.Read())
            {
                string dataname = dataReader1["name"].ToString();
                int dataId = (int)dataReader1["id"];
                Products products = new Products(dataId, dataname);
                listData.Add(products);
            }

            return listData;
        }

        public List<Products> ReadIdProductsForName(string name)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id, name FROM products WHERE name='" + name + "';";
            List<Products> listData = new List<Products>();
            MySqlDataReader dataReader1 = cmd.ExecuteReader();
            while (dataReader1.Read())
            {
                string dataname = dataReader1["name"].ToString();
                int dataIdproduct = (int)dataReader1["id"];
                Products products = new Products(dataIdproduct, dataname);
                listData.Add(products);
            }

            return listData;

        }
        public List<Products> ReadProductsForId(int id)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT products.id AS idproducts, products.name AS porductname, categories.name AS categorie, categories.id AS idcategorie FROM products INNER JOIN categories ON products.Categories_id = categories.id WHERE products.id =" + id + ";";
            List<Products> listData = new List<Products>();
            MySqlDataReader dataReader1 = cmd.ExecuteReader();
            while (dataReader1.Read())
            {
                string dataname = dataReader1["porductname"].ToString();
                int dataIdproduct = (int)dataReader1["idproducts"];
                int dataIdcategorie = (int)dataReader1["idcategorie"];
                string dataCategorie = dataReader1["categorie"].ToString();
                Products products = new Products(dataIdproduct, dataname, dataCategorie, dataIdcategorie);
                listData.Add(products);
            }

            return listData;
        }


        /// <summary>
        /// Lire les produits d'un fournisseur 
        /// </summary>
        /// <param name="idsuppliers"></param>
        /// <returns></returns>
        public List<Products> ReadProductsHasSuppliers(int idsuppliers)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT products.id, products.Name FROM products_has_suppliers inner JOIN products ON Products_id = products.id inner JOIN suppliers ON Suppliers_id = suppliers.id  WHERE suppliers.id =" + idsuppliers + ";";
            List<Products> list = new List<Products>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string dataName = dataReader["Name"].ToString();
                int dataId = (int)dataReader["id"];
                Products dataProducts = new Products(dataId, dataName);
                list.Add(dataProducts);
            }

            return list;
        }

        /// <summary>
        /// Lire les categories 
        /// </summary>
        /// <returns></returns>
        public List<Categorie> ReadCategories()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id,Name FROM Categories";
            List<Categorie> list = new List<Categorie>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string dataName = dataReader["Name"].ToString();
                int dataId = (int)dataReader["id"];
                Categorie datacategorie = new Categorie(dataId, dataName);
                list.Add(datacategorie);
            }

            return list;
        }

        /// <summary>
        /// Lire les Unités 
        /// </summary>
        /// <returns></returns>
        public List<Unities> ReadUnities()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id,Name FROM Unities";
            List<Unities> list = new List<Unities>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string dataName = dataReader["Name"].ToString();
                int dataId = (int)dataReader["id"];
                Unities dataUnities = new Unities(dataId, dataName);
                list.Add(dataUnities);
            }

            return list;
        }

        public void InsertCommandeLine(int quantity, int productsid, int unitiesid, int suppliersid, int status )
        {
            string thisDay = System.DateTime.Now.ToString("dd/MM/yyyy");
            string commande = "INSERT INTO commandelines(Quantity,OrderDate,Products_id,Unities_id,Suppliers_id,Status) VALUES("+quantity+",'"+ thisDay+"',"+ productsid+","+unitiesid+","+suppliersid+","+status+");";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
       
        public List<CommandeLines> ReadStock()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT commandelines.id, products.name AS Produit, categories.name AS categorie, unities.Name AS Unitie, commandelines.Quantity, commandelines.Peremption FROM commandelines inner JOIN products ON commandelines.Products_id = products.id LEFT JOIN suppliers ON commandelines.Suppliers_id = suppliers.id INNER JOIN categories ON products.Categories_id = categories.id INNER JOIN unities ON commandelines.Unities_id = unities.id WHERE commandelines.Status = 1";
            List<CommandeLines> list = new List<CommandeLines>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string nameproduit = dataReader["Produit"].ToString();
                string namecategorie = dataReader["categorie"].ToString();
                string unities = dataReader["Unitie"].ToString();
                int quantity = (int)dataReader["Quantity"];
                string Peremption = dataReader["Peremption"].ToString();
                CommandeLines dataUnities = new CommandeLines(id, nameproduit, namecategorie, quantity, unities, Peremption);
                list.Add(dataUnities);
            }

            return list;
        }

        public List<CommandeLines> ReadCommandes()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT commandelines.id, commandelines.OrderDate, products.name AS Produit, unities.Name AS Unitie, categories.name AS categorie, commandelines.Quantity, commandelines.Peremption FROM commandelines inner JOIN products ON commandelines.Products_id = products.id inner JOIN suppliers ON commandelines.Suppliers_id = suppliers.id INNER JOIN categories ON products.Categories_id = categories.id INNER JOIN unities ON commandelines.Unities_id = unities.id WHERE commandelines.Status = 0";
            List<CommandeLines> list = new List<CommandeLines>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string nameproduit = dataReader["Produit"].ToString();
                string unities = dataReader["Unitie"].ToString();
                int quantity = (int)dataReader["Quantity"];
                string orderday = dataReader["OrderDate"].ToString();
                CommandeLines dataUnities = new CommandeLines(id, nameproduit, unities, quantity, orderday);
                list.Add(dataUnities);
            }

            return list;
        }

        

    }
}
