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

            string connectionString = "SERVER=10.229.33.3; DATABASE=Gestionnaire; UID=Stephane; PASSWORD=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);

        }
        //créer un objet fournisseur qui sera crée quand on appuye sur valider--> l'objet sera mis en parametre de Addsupplier
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

                cmd.Parameters.AddWithValue("@Firstname", user.firstName);
                cmd.Parameters.AddWithValue("@Lastname", user.lastName);
                cmd.Parameters.AddWithValue("@NameRest", user.nameRestaurant);
                cmd.Parameters.AddWithValue("@City", user.city);
                cmd.Parameters.AddWithValue("@NPA", user.npa);
                cmd.Parameters.AddWithValue("@Street", user.street);
                cmd.Parameters.AddWithValue("@Email", user.email);

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
    }
    }
}
