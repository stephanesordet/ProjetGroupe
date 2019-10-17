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
        int idproduitforname;
        int idcategorie = 0;
        int clikloupe = 0;
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
                clikloupe = 1;
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
                    idcategorie = value.idcategorie;
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

        private void CmdValider_Click(object sender, EventArgs e)
        {
            if (txtnomproduit.Text != "" && cmbCategorie.SelectedItem != null && txtQuantite.Text != "" && cmbUnites.SelectedItem != null)
            {

                //Verifie si le nom du produit existe deja
                MysqlConn.OpenDB();
                List<Products> listIdProducts = MysqlConn.ReadIdProductsForName(txtnomproduit.Text);
                foreach (Products value in listIdProducts)
                {
                    idproduitforname = (int)value.id;
                }
                MysqlConn.CloseDB();
                //Recuperer la unite selectione
                Unities unitesdata = (Unities)cmbUnites.SelectedItem;
                int quantityint = int.Parse(txtQuantite.Text);

                //Si le produit existe dans la base de donnee 
                if (idproduitforname > 0)
                {
                    MysqlConn.OpenDB();
                    MysqlConn.InsertProduisHasCommandeLine(quantityint, idproduitforname, unitesdata.id, txtDatePeremption.Text, 1);
                    MysqlConn.CloseDB();
                    MessageBox.Show("Votre produit a été ajouté dans stock");
                }
                //Si le produit n'existe pas
                else
                {
                    Categorie categoriedate = (Categorie)cmbCategorie.SelectedItem;
                    MysqlConn.OpenDB();
                    //Ajouter le produit dans la base
                    long idproduitnew = MysqlConn.InsertProduit(txtnomproduit.Text, categoriedate.id);
                    MysqlConn.CloseDB();
                    MysqlConn.OpenDB();
                    //Ajouter en stock le nouveau produit
                    MysqlConn.InsertProduisHasCommandeLine(quantityint, (int)idproduitnew, unitesdata.id, txtDatePeremption.Text, 1);
                    MysqlConn.CloseDB();
                    MessageBox.Show("Votre nouveau produit a été ajouté dans stock et a été sauvergarde, vous pouviez le reutilizer");
                }
            }

            else
            {
                MessageBox.Show("Remplir tous les champs obligatoire");
            }
        }
    }
}
