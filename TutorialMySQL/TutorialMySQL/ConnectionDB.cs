using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FAO : repris de http://blog.mounier-logiciels.fr/comment-creer-une-connection-mysql-local-en-CSharp.html
//Créer auparavant la BD mli et la table contact avec les champs id, name et tel.
//Adapter les critères de connection
//Attention, il n'y aucune gestion d'erreur (exceptions)!!!!!
namespace TutorialMySQL
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
            
            string connectionString = "SERVER=127.0.0.1; DATABASE=mli; UID=fandolfatto; PASSWORD=P@ssw0rd";
            connection = new MySqlConnection(connectionString);
            
        }

        // Méthode pour ajouter un contact
        public void AddContact(Contact contact)
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
        }


    }
}
