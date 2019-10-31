using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

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

        /// <summary>
        /// initialiser la connexion
        /// </summary>
        private void InitConnexion()
        {
            // Création de la chaîne de connexion

            // string connectionString = "SERVER=10.229.33.3; DATABASE=Gestionnaire; UID=Stephane; PASSWORD=Pa$$w0rd";
            string connectionString = "SERVER=10.229.33.3; DATABASE=Gestionnaire; UID=Stephane; PASSWORD=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);

        }

        /// <summary>
        /// Ouvrir la connexion Mysql
        /// </summary>
        public void OpenDB()
        {
            connection.Open();
        }
        /// <summary>
        /// Fermer la conexions à Mysql 
        /// </summary>
        public void CloseDB()
        {
            connection.Close();
        }

        /// <summary>
        /// Insertion des produits dans la table Products
        /// </summary>
        /// <param name="name">Nom du produit à inserer</param>
        /// <param name="categorie">Catégorie du produit</param>
        /// <returns></returns>
        public long InsertProducts(string name, int categorie)
        {
            string produit = "INSERT INTO products(Name,Categories_id) VALUES('" + name + "'," + categorie + ");";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(produit, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;

        }

        public long InsertProduitNonFourni(string name, int categorie)
        {
            string produit = "INSERT INTO products(Name,Categories_id) VALUES('" + name + "'," + categorie + ");";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(produit, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }

        /// <summary>
        /// Changer le status de 0 à 1 dans la table CommandeLines
        /// </summary>
        /// <param name="id">Id de la commande</param>
        public void UpdateStatus(int id)
        {
            string updatestatus = "UPDATE CommandeLines SET Status = 2 WHERE id =" + id + ";";
            MySqlCommand cmd = new MySqlCommand(updatestatus, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Insérer categories dans la table Categories
        /// </summary>
        /// <param name="name">Nom de la catégorie</param>
        public void InsertCategorie(string name)
        {
            string commande = "INSERT INTO Categories(Name) VALUES('" + name + "');";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Relier un produit à un fournisseur dans la table Products_has_Suppliers
        /// </summary>
        /// <param name="idproducts">Id du produit</param>
        /// <param name="idsuppliers">Id du fournisseur</param>
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
                
                cmd.Parameters.AddWithValue("@Firstname",supplier.FirstName );
                cmd.Parameters.AddWithValue("@Lastname", supplier.LastName);
                cmd.Parameters.AddWithValue("@Company", supplier.Company);
                cmd.Parameters.AddWithValue("@City", supplier.City);
                cmd.Parameters.AddWithValue("@NPA", supplier.Npa);
                cmd.Parameters.AddWithValue("@Street", supplier.Street);
                cmd.Parameters.AddWithValue("@Email", supplier.Email);

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
        /// <summary>
        /// Insérer un produit dans le stock, table CommandeLines 
        /// </summary>
        /// <param name="quantity">Quantité du produit</param>
        /// <param name="productsid">Nom du produit</param>
        /// <param name="unitiesid">Unite selectioné</param>
        /// <param name="peremption">Date de peremption</param>
        /// <param name="status">Satus = 1</param>
        public void InsertProduisHasCommandeLine(int quantity, int productsid, int unitiesid, string peremption, int status)
        {
            string commande;
            //Si l'utilisateur a entrée une date de peremption 
            if (peremption != "")
            {
                commande = "INSERT INTO commandelines(Quantity,Products_id,Unities_id,Peremption,Status) VALUES(" + quantity + "," + productsid + "," + unitiesid + ",'" + peremption + "'," + status + ");";
            }
            //Si l'utilisateur n'a pas entrée une date de peremption 
            else
            {
               commande = "INSERT INTO commandelines(Quantity,Products_id,Unities_id,Status) VALUES(" + quantity + "," + productsid + "," + unitiesid + "," + status + ");";
            }
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Realiser une commande. Inserer le donne dans la table CommandeLines
        /// </summary>
        /// <param name="quantity">Quantié désiré par le client</param>
        /// <param name="productsid">Id du produit désiré</param>
        /// <param name="unitiesid">Id de l'unite selectioné</param>
        /// <param name="suppliersid">Id du fonisseur désiré</param>
        /// <param name="status">Status de la commande</param>
        public void InsertCommandeLine(int quantity, int productsid, int unitiesid, int suppliersid, int status)
        {
            string thisDay = System.DateTime.Now.ToString("dd/MM/yyyy");
            string commande = "INSERT INTO commandelines(Quantity,OrderDate,Products_id,Unities_id,Suppliers_id,Status) VALUES(" + quantity + ",'" + thisDay + "'," + productsid + "," + unitiesid + "," + suppliersid + "," + status + ");";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprimer dans la table CommandeLines
        /// </summary>
        /// <param name="idproduit">Id du produit</param>
        public void DeletInStock(int idproduit)
        {
            string commande = "Delete From commandelines WHERE commandelines.id =" + idproduit + " AND commandelines.status = 1;";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Mise à jour du produit, table Products 
        /// </summary>
        /// <param name="idproduit">Id du produit</param>
        /// <param name="nomproduit">Nom du produit</param>
        /// <param name="idcategorie">Categorie du produit</param>
        public void UpdateProducts(int idproduit, string nomproduit, int idcategorie)
        {
            string commande = "UPDATE Products SET Name='"+nomproduit+"',Categories_id ="+ idcategorie + " WHERE id =" + idproduit + ";";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Mise à jour de la table CommandeLines
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="quantity">Quantité</param>
        /// <param name="date">Date de peremption</param>
        /// <param name="idunities">Unités</param>
        public void UpdateCommandeLines(int id, int quantity, string date,  int idunities)
        {
            string commande = "UPDATE CommandeLines SET Quantity="+quantity+",Peremption='"+date+"',Unities_id="+idunities+" WHERE id ="+id+";";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Lire les fournisseur dans la table Suppliers
        /// </summary>
        /// <returns>Retune la liste de tous les fournisseurs</returns>
        public List<Supplier> ReadSuplliers()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Firstname,Lastname,id,email FROM suppliers";
            List<Supplier> listData = new List<Supplier>();
            MySqlDataReader dataReader1 = cmd.ExecuteReader();
            while (dataReader1.Read())
            {               
                string dataFirstanme = dataReader1["Firstname"].ToString();
                string dataLastnme = dataReader1["Lastname"].ToString();
                int dataId = (int)dataReader1["id"];
                string dataemail = dataReader1["email"].ToString();
                Supplier fournisseurs = new Supplier(dataId, dataFirstanme, dataLastnme, dataemail);
                listData.Add(fournisseurs);
            }

            return listData;


        }
        /// <summary>
        /// Lire les produits^dans la table Products
        /// </summary>
        /// <returns>Retune la liste de tous les prodtuis</returns>
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
        /// <summary>
        /// Lire les produits^dans la table Products par rapport à sa catégorie
        /// </summary>
        /// <param name="categorie">Catégorie d</param>
        /// <returns></returns>
        public List<Products> ReadProductsForCategories(string categorie)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Products.Name,Products.id FROM Products INNER JOIN categories ON products.Categories_id = categories.id WHERE categories.name ='" + categorie + "';";
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
        /// <summary>
        /// Lire le Id du produit par rapport à son nom, dans la table Products
        /// </summary>
        /// <param name="name">Nom du produit désiré</param>
        /// <returns>Retune la liste de tous les produits</returns>
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
        /// <summary>
        /// Lire le nom du produit par rapport à son Id, dans la table Products
        /// </summary>
        /// <param name="id">Id du produit désiré</param>
        /// <returns>Retune la liste de tous les produits</returns>
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
        /// Lire les produits relier à des fournisseurs, dans la table Products_has_Suppliers 
        /// </summary>
        /// <param name="idsuppliers">Id du fournisseur désiré</param>
        /// <returns>Retune la liste de tous les produits</returns>
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
        /// Lire les categories dans la table Categories
        /// </summary>
        /// <returns>Retune la liste de tous les categories</returns>
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
        /// Lire les Unités dans la table Unities 
        /// </summary>
        /// <returns>Retune la liste de tous les unites</returns>
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
        public void sendMail(Mail mail)
        {       
       
            SmtpClient test = new SmtpClient("mail.cpnv.ch", 25);

            try
            {
                test.Send(mail.Sender, mail.Recipient, mail.Subject, mail.Body);
                MessageBox.Show("Email ok");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        /// <summary>
        /// Lire les produis consideré comme stock, status = 1, dans la table CommandeLines
        /// </summary>
        /// <returns>Retune la liste de tous les produits</returns>
        public List<CommandeLines> ReadStock()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT commandelines.id, products.name AS Produit, categories.name AS categorie, unities.Name AS Unitie, commandelines.Quantity, commandelines.Peremption FROM commandelines inner JOIN products ON commandelines.Products_id = products.id LEFT JOIN suppliers ON commandelines.Suppliers_id = suppliers.id INNER JOIN categories ON products.Categories_id = categories.id INNER JOIN unities ON commandelines.Unities_id = unities.id WHERE commandelines.Status = 1 OR 2";
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
        /// <summary>
        /// Lire les produits consideré comme commande en cours, status = 0, dans la table CommandeLines
        /// </summary>
        /// <returns>Retune la liste de tous les produits</returns>
        public List<CommandeLines> ReadCommandes()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT commandelines.id, commandelines.OrderDate, products.name AS Produit, unities.Name AS Unitie, categories.name AS categorie, commandelines.status AS status, commandelines.Quantity, commandelines.Peremption FROM commandelines inner JOIN products ON commandelines.Products_id = products.id inner JOIN suppliers ON commandelines.Suppliers_id = suppliers.id INNER JOIN categories ON products.Categories_id = categories.id INNER JOIN unities ON commandelines.Unities_id = unities.id WHERE commandelines.Status = 0  OR commandelines.Status = 2";
            List<CommandeLines> list = new List<CommandeLines>();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = (int)dataReader["id"];
                string nameproduit = dataReader["Produit"].ToString();
                string unities = dataReader["Unitie"].ToString();
                int quantity = (int)dataReader["Quantity"];
                string orderday = dataReader["OrderDate"].ToString();
                int status = (int)dataReader["status"];
                CommandeLines dataUnities = new CommandeLines(id, nameproduit, unities, quantity, orderday, status);
                list.Add(dataUnities);
            }

            return list;
        }

        

    }
}
