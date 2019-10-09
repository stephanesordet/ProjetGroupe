using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

            string connectionString = "SERVER=10.229.33.3; DATABASE=Gestionnaire; UID=Stephane; PASSWORD=Pa$$w0rd";
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

        public long InsertProduit(string name, int categorie)
        {
            string produit = "INSERT INTO products(Name,Categories_id) VALUES('" + name + "'," + categorie + ");";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(produit, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;

        }
        public void InsertProductsSuppliers(long idproducts, long idsuppliers)
        {
            string commande = "INSERT INTO Products_has_Suppliers(Products_id,Suppliers_id) VALUES(" + idproducts + "," + idsuppliers + ");";
            MySqlCommand cmd = new MySqlCommand(commande, connection);
            cmd.ExecuteNonQuery();
        }


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

        public void AddUser(User user)
        {
            try
            {
                // Ouverture de la connexion SQL
                connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO restaurants (Firstname, Lastname, NameRest, City, NPA, Street, Email) VALUES (@Firstname, @Lastname, @NameRest, @City, @NPA, @Street, @Email)";

                // utilisation de l'objet contact passé en paramètre

                cmd.Parameters.AddWithValue("@Firstname", user.FirstName);
                cmd.Parameters.AddWithValue("@Lastname", user.LastName);
                cmd.Parameters.AddWithValue("@NameRest", user.NameRestaurant);
                cmd.Parameters.AddWithValue("@City", user.City);
                cmd.Parameters.AddWithValue("@NPA", user.Npa);
                cmd.Parameters.AddWithValue("@Street", user.Street);
                cmd.Parameters.AddWithValue("@Email", user.Email);

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

        public List<Categorie> ReadCategories()
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id,Name FROM Categories";
            List<Categorie> list = new List<Categorie>();
            MySqlDataReader dataReader1 = cmd.ExecuteReader();
            while (dataReader1.Read())
            {
                string dataName = dataReader1["Name"].ToString();
                int dataId = (int)dataReader1["id"];
                Categorie datacategorie = new Categorie(dataId, dataName);
                list.Add(datacategorie);
            }

            return list;
        }


    }
    

    
}
