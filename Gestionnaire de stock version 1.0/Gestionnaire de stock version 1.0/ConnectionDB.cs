using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void InitConnexion()
        {
            // Création de la chaîne de connexion

            string connectionString = "SERVER=10.229.33.3; DATABASE=gestionnaire; UID=Luana; PASSWORD=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);          
        }


        public void OpenDB()
        {
            connection.Open();
        }
        public void CloseDB()
        {
            connection.Close();
        }

        //methode pour add des produits
        public long InsertProduit(string name)
        {
            string categorie = "INSERT INTO products(Name) VALUES('" + name + "');";
            // Création d'une commande MySQL en fonction de l'objet connection
            MySqlCommand cmd = new MySqlCommand(categorie, connection);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;

        }

        /// <summary>
        /// Lire les produits 
        /// </summary>
        public void ReadProducts()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void Insertcategories(string name)
        {
        

        }

        /// <summary>
        /// Methode lire la table caregories
        /// </summary>
        public void Readcategories()
        {


        }

        /// <summary>
        /// Methode lire le nom et le prenom des fornisseur 
        /// </summary>
        /// <returns>Liste avec tout les fornisseur</returns>
        public List<string> ReadFournisseur()
        {
            //Le problème que vous rencontrez est que vous démarrez une seconde MySqlCommandtout en lisant les données avec le DataReader. Le connecteur MySQL n'autorise qu'une requête simultanée. Vous devez lire les données dans une structure, puis fermer le lecteur, puis traiter les données. Malheureusement, vous ne pouvez pas traiter les données telles qu'elles sont lues si votre traitement implique d'autres requêtes SQL.
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Firstname,Lastname FROM suppliers";
            List<string> list = new List<string>();
            MySqlDataReader dataReader1 = cmd.ExecuteReader();
            while (dataReader1.Read())
            {
              
                string myReader = dataReader1["Firstname"].ToString();
                string myReader1 = dataReader1["Lastname"].ToString();
                list.Add(myReader+ " " + myReader1);
            }
            return list;
         
            
        }


        // Méthode pour ajouter un contact
        /*public void AddContact(Contact contact)
        {
            try
            {
                // Ouverture de la connexion SQL
                connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO contact (id, name, tel) VALUES (@id, @name, @tel)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id", contact.Id);
                cmd.Parameters.AddWithValue("@name", contact.Name);
                cmd.Parameters.AddWithValue("@tel", contact.Tel);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                connection.Close();
            }
            catch (Exception exc)
            {

                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }*/
    }
}
