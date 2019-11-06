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
    public partial class FrmLoupeProduitStcok : Form
    {
        FrmProduitStock formproduit;
        ConnectionDB MysqlConn = new ConnectionDB();
        public int idproduit;
        List<Categorie> listCategories;
        public FrmLoupeProduitStcok()
        {
            InitializeComponent();
        }

        private void cmdValidder_Click(object sender, EventArgs e)
        {
            if (lstProduits.SelectedIndex != -1)
            {
                formproduit = new FrmProduitStock();
                if (lstProduits.SelectedIndex != -1)
                {
                    //Recuperer le Id du produit selectionnée
                    Products produit = (Products)lstProduits.SelectedItem;
                    idproduit = (int)produit.Id;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Selectionner un produit");
            }
        }
        private void Readproducts()
        {
            MysqlConn.OpenDB();
            List<Products> lisproduits = MysqlConn.ReadProducts();
            foreach (Products value in lisproduits)
            {
                lstProduits.Items.Add(value);
            }

            MysqlConn.CloseDB();
        }

        private void FrmLoupeProduitStcok_Load(object sender, EventArgs e)
        {
            //Lire les Produits
            Readproducts();
            
            // Read list categorie
            MysqlConn.OpenDB();
            cboCategorie.Items.Add("Tous les produits");
            listCategories = MysqlConn.ReadCategories();
            foreach (Categorie value in listCategories)
            {
                cboCategorie.Items.Add(value);
            }
            MysqlConn.CloseDB();
        }
        private void picReturne_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void cboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProduits.Items.Clear();
            if (cboCategorie.SelectedItem.ToString() == "Tous les produits")
            {
                Readproducts();
            }
            else
            {
                //Recuperer la categorie selectionnée
                Categorie categoriesselectione = (Categorie)cboCategorie.SelectedItem;
                MysqlConn.OpenDB();
                List<Products> lisproduitsforcategorie = MysqlConn.ReadProductsForCategories(categoriesselectione.Name);
                foreach (Products value in lisproduitsforcategorie)
                {
                    lstProduits.Items.Add(value);
                }
                MysqlConn.CloseDB();
            }
        }

    }
}
