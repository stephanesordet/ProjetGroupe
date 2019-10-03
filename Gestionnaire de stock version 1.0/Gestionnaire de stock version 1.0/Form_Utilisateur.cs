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

            //Déclaration de supplier
            User user;

            //Si Email OK
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

                user = new User(txtNom.Text, txtPrenom.Text, txtRestaurant.Text, npa, txtVille.Text, txtRue.Text, txtEmail.Text);

                addUser.AddUser(user);
            }
            else
            {
                MessageBox.Show("coucou fdp");
            }


        }
        //Fonction contrôle de l'Email
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
    }
    }
}
