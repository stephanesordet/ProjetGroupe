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
        int idproduct;
        List<Categorie> listCategories;
        int idproduitforname;
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
            if (txtNom.Text != "")
            {
                MysqlConn.OpenDB();
                idproduitforname = 0;
                //Verifier si le nom du produit existe deja 
                List<Products> listIdProducts = MysqlConn.ReadIdProductsForName(txtNom.Text);
                foreach (Products value in listIdProducts)
                {
                    idproduitforname = (int)value.Id;
                }
                MysqlConn.CloseDB();
                
                //Si le produit existe dans la base de donnee 
                if (idproduitforname > 0)
                {
                    if (lstFournisseur.SelectedItem != null)
                    {
                        foreach (Supplier selecteditem in lstFournisseur.SelectedItems)
                        {
                            MysqlConn.OpenDB();
                            Supplier fournisseur = (Supplier)selecteditem;
                            MysqlConn.InsertProductsSuppliers(idproduitforname, fournisseur.Id);
                            MysqlConn.CloseDB();
                        }
                        MessageBox.Show("Votre produit a été associé avec un ou plusieurs fournisseurs");
                    }
                    else
                    {
                        MessageBox.Show("Votre produit existe déjà, vous devez l'associer avec un ou plusieurs fournisseurs ");
                    }

                }
                //Si le produit n'existe pas sur la base de donnee 
                else
                {
                    if (cboCategorie.SelectedItem != null)
                    {
                        Categorie categories = (Categorie)cboCategorie.SelectedItem;
                        //L'utilisateur a l'option de ajouter un produit et l'associer avec un ou plusieurs fournisseur 
                        if (lstFournisseur.SelectedItem != null)
                        {
                            MysqlConn.OpenDB();
                            long idProduit = MysqlConn.InsertProducts(txtNom.Text, categories.Id);
                            MysqlConn.CloseDB();
                            foreach (Supplier selecteditem in lstFournisseur.SelectedItems)
                            {
                                MysqlConn.OpenDB();
                                Supplier fournisseur = (Supplier)selecteditem;
                                MysqlConn.InsertProductsSuppliers(idProduit, fournisseur.Id);
                                MessageBox.Show("Votre produit a été ajouté et associé avec un ou plusieurs fournisseurs");
                                MysqlConn.CloseDB();
                            }
                        }
                        //Ajouter un produit sans l'associer à un fournisseur  
                        else
                        {
                            MysqlConn.OpenDB();
                            MysqlConn.InsertProducts(txtNom.Text, categories.Id);
                            MessageBox.Show("Votre produit a été ajouté mais n'a pas été associé avec un fournisseurs");
                            MysqlConn.CloseDB();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sélectionner de nouveau une catégorie");
                    }
                }
                txtNom.Text = "";
                Lirecategorie();
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
            List<Supplier> listSupplier = MysqlConn.ReadSuplliers();
            foreach (Supplier value in listSupplier)
            {
                lstFournisseur.Items.Add(value);
            }
            MysqlConn.CloseDB();
            //Read list categorie 
            Lirecategorie();

        }

        private void Lirecategorie()
        {
            
            cboCategorie.Items.Clear();
            MysqlConn.OpenDB();
            listCategories = MysqlConn.ReadCategories();
            foreach (Categorie value in listCategories)
            {
                cboCategorie.Items.Add(value);
            }

            MysqlConn.CloseDB();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            {

            }
            else
            {
                cboCategorie.Enabled = true;
                Lirecategorie();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                    txtNom.Text = value.Name.ToString();
                    cboCategorie.Items.Clear();
                    cboCategorie.Items.Add(value.Categoriename);
                    cboCategorie.SelectedIndex = 0;
                    cboCategorie.Enabled = false;
                }
               
                MysqlConn.CloseDB();

            }
            else
            {

            }
        }
    }

}

