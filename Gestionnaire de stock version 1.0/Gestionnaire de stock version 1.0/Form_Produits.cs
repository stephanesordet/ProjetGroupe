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
    public partial class FrmProduits : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();
        public FrmProduits()
        {
            InitializeComponent();
        }

        private void Picretournemenu_Click(object sender, EventArgs e)
        {
            FrmMenu form1 = new FrmMenu();
            form1.Show();
            this.Hide();
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != " ")
            {
                MysqlConn.OpenDB();
                if (cmbCategorie.SelectedItem != null)
                {
                    if(lstFournisseur.SelectedItem != null)
                    {
                        Categorie categories = (Categorie)cmbCategorie.SelectedItem;
                        long idProduit = MysqlConn.InsertProduit(txtNom.Text, categories.id);

                       foreach(Supplier selecteditem in lstFournisseur.SelectedItems)
                        {
                            Supplier fournisseur = (Supplier)selecteditem;
                            MysqlConn.InsertProductsSuppliers(idProduit, fournisseur.id);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter au moins un fournisseur");
                    }
                }
                else
                {
                    MessageBox.Show("Entrer un nom de produit");
                }
                MysqlConn.CloseDB();
            }

            else
            {
                MessageBox.Show("Entrer un nom de produit");
            }

        }

        private void FrmProduits_Load(object sender, EventArgs e)
        {
            lstFournisseur.SelectionMode = SelectionMode.MultiSimple;
            MysqlConn.OpenDB();
            List<Supplier> listSupplier = MysqlConn.ReadFournisseur();
            foreach (Supplier value in listSupplier)
            {
                lstFournisseur.Items.Add(value);
            }
            MysqlConn.CloseDB();
            MysqlConn.OpenDB();
            List<Categorie> listCategories = MysqlConn.ReadCategories();
                foreach (Categorie value in listCategories)
                {
                    cmbCategorie.Items.Add(value);
                }

                MysqlConn.CloseDB();

        }
     }

}

