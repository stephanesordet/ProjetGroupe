using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Gestionnaire_de_stock_version_1._0
{
    public partial class FrmFournisseur : Form
    {
        
        public FrmFournisseur()
        {
            InitializeComponent();
        }

        private void pic_returnemenu_Click(object sender, EventArgs e)
        {
            FrmMenu form1 = new FrmMenu();
            form1.Show();
            this.Hide();
        }

        private void cmdvalider_Click(object sender, EventArgs e)
        {
            
            ConnectionDB addSupp = new ConnectionDB();

            int npa = 0;
            string sexe = "";
            

            //Déclaration de supplier
            Supplier supplier;

            //Si Email OK
            if (IsValidEmail(txtEmail.Text))
            {
                try
                {
                    //Conversion de NPA en int
                    int.TryParse(txtNpa.Text, out npa);

                    //Contrôle que le NPA peut être converti 
                    if (chkM.Checked == true)
                    {
                        sexe = "Monsieur";
                    }
                    else
                    {
                        sexe = "Madame";
                    }


                }
                catch
                {
                    MessageBox.Show("NPA non valide");
                }

                supplier = new Supplier(sexe, txtNom.Text, txtPrenom.Text, txtEntreprise.Text, npa, txtVille.Text, txtRue.Text, txtEmail.Text);

                addSupp.AddSupplier(supplier);
            }
            else
            {
                MessageBox.Show("Email invalide");
                
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

        private void FrmFournisseur_Load(object sender, EventArgs e)
        {

        }
    }


}
