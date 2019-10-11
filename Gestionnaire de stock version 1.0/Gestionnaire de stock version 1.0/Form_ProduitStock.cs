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
    public partial class FrmProduitStock : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();
        public int idproduct;
        List<Categorie> listCategories;
        List<Unities> listUnities;
        public FrmProduitStock()
        {
            InitializeComponent();
        }


        private void FrmProduitStock_Load(object sender, EventArgs e)
        {
            MysqlConn.OpenDB();
            //Lire les categories
            listCategories = MysqlConn.ReadCategories();
            foreach (Categorie value in listCategories)
            {
                //Add categories
                cmbCategorie.Items.Add(value);
            }

            MysqlConn.CloseDB();
            //Lire les unites
            MysqlConn.OpenDB();
            listUnities = MysqlConn.ReadUnities();
            foreach (Unities value in listUnities)
            {
                cmbUnites.Items.Add(value);
            }

            MysqlConn.CloseDB();
        }

        private void picLoupProuduits_Click(object sender, EventArgs e)
        {
            FrmLoupeProduitStcok formloupe = new FrmLoupeProduitStcok();
            //Open formulare
            formloupe.ShowDialog();
            //Recuperer le ID du produit selectionée 
            idproduct = formloupe.idproduit;
            //Si un produit a étè selectionée 
            if (idproduct != 0)
            {
                //Lire le Produit
                MysqlConn.OpenDB();
                //Lire le produit du id selectionne 
                List<Products> lisproduits = MysqlConn.ReadProductsForId(idproduct);
                foreach (Products value in lisproduits)
                {
                    txtnomproduit.Text = value.name.ToString();
                    cmbCategorie.Items.Clear();
                    cmbCategorie.Items.Add(value.categoriename);
                    cmbCategorie.SelectedIndex = 0;
                    cmbCategorie.Enabled = false;
                }

                MysqlConn.CloseDB();

            }
            else
            {
               
            }
        }

        private void txtnomproduit_TextChanged(object sender, EventArgs e)
        {
            
            if(txtnomproduit.Text != "")
            {

            }
            else
            {
                cmbCategorie.Enabled = true;
                cmbCategorie.Items.Clear();
                MysqlConn.OpenDB();
                List<Categorie> listCategories = MysqlConn.ReadCategories();
                foreach (Categorie value in listCategories)
                {
                    cmbCategorie.Items.Add(value);
                }

                MysqlConn.CloseDB();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmStock formstock = new FrmStock();
            formstock.Show();
            this.Hide();
        }
    }
}
