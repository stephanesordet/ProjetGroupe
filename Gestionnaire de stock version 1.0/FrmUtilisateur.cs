using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_stock_version_1._0
{
    public partial class FrmUtilisateur : Form
    {
        int idUser = 0;
        ConnectionDB MysqlConn = new ConnectionDB();
        public FrmUtilisateur()
        {
            InitializeComponent();
        }

        private void picreturnemenu_Click(object sender, EventArgs e)
        {
            FrmMenu form1 = new FrmMenu();
            form1.Show();
            this.Hide();
        }

        private void cmdvalider_Click(object sender, EventArgs e)
        {
            ConnectionDB addUser = new ConnectionDB();

            int npa = 0;


            //Déclaration de user
            User newUser;

            if (IsValidEmail(txtEmail.Text))
            {
                try
                {
                    //Conversion de NPA en int
                    int.TryParse(txtNpa.Text, out npa);
                }
                catch
                {
                    MessageBox.Show("NPA non valide");
                }

                if (idUser != 0)
                {
                    addUser.OpenDB();
                    addUser.UpdateUser(idUser, txtNom.Text, txtPrenom.Text, txtRestaurant.Text, txtVille.Text, npa, txtRue.Text, txtEmail.Text);
                    addUser.CloseDB();
                    MessageBox.Show("Données actualisées");
                }
                else
                {
                    newUser = new User(txtNom.Text, txtPrenom.Text, txtRestaurant.Text, txtVille.Text, npa, txtRue.Text, txtEmail.Text);
                    addUser.AddUser(newUser);
                    MessageBox.Show("Utilisateur ajouté");
                }
            }
            else
            {
                MessageBox.Show("Email invalide");

            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {
            
            MysqlConn.OpenDB();
            //Lire la list des fournisseurs 
            List<User> listSupplier = MysqlConn.ReadUser();
            foreach (User value in listSupplier)
            {
               idUser = value.Id;
            }
            MysqlConn.CloseDB();

            if (idUser > 0)
            {
                foreach (User value in listSupplier)
                {
                    txtNom.Text = value.FirstName;
                    txtPrenom.Text = value.LastName;
                    txtRestaurant.Text = value.NameRestaurant;
                    txtVille.Text = value.City;
                    txtNpa.Text = value.Npa.ToString();
                    txtNom.Text = value.FirstName;
                    txtRue.Text = value.Street;
                    txtEmail.Text = value.Email;
                }
            }

        }
    }
}
