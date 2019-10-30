﻿using System;
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
        
        //Recuperer les informations du produit selectionne pour modifer 
        public bool modifierProduit = false;
        public int modifierIdProduit;
        public int modiferIdCommandeLines;
        public string modifierNomProduit;
        public int modiferQuantite;
        public string modiferUnite;
        public string modiferDate;
        public string modiferCategorie;
        string valuechangecmb;

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

            //Pour un produit modifiable 
            if(modifierProduit == true)
            {
                lblProduitStcok.Text = "     MODIFER LE PRODUIT";
                picLoupProuduits.Visible = false;
                txtnomproduit.Text = modifierNomProduit;

                MysqlConn.OpenDB();
                //Recuperer le ID du produit 
                List<Products> listIdProducts = MysqlConn.ReadIdProductsForName(modifierNomProduit);
                foreach (Products value in listIdProducts)
                {
                    modifierIdProduit = (int)value.id;
                }
                MysqlConn.CloseDB();
            
                
                txtDatePeremption.Text = modiferDate;
                //Selectioner la categorie 
                foreach (object item in cmbCategorie.Items)
                {
                    if(item.ToString() == modiferCategorie)
                    {
                        cmbCategorie.SelectedItem = item;
                        valuechangecmb = item.ToString();
                    }

                }
                //Selectioner la unite
                foreach (object item in cmbUnites.Items)
                {
                    if (item.ToString() == modiferUnite)
                    {
                        cmbUnites.SelectedItem = item;
                    }

                }
                txtQuantite.Text = modiferQuantite.ToString();
                picReturne.Visible = false;

                
            }
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


        private void CmdValider_Click(object sender, EventArgs e)
        {
            if (txtnomproduit.Text != "" && cmbCategorie.SelectedItem != null && txtQuantite.Text != "" && cmbUnites.SelectedItem != null)
            {

                //Modification d'un produit 
                if (modifierProduit == true)
                {
                    //Recuperer la unite selectione
                    Unities unitesdata = (Unities)cmbUnites.SelectedItem;
                    Categorie categoriedate = (Categorie)cmbCategorie.SelectedItem;
                    //Si il a modifier le nom du produit 
                    if (txtnomproduit.Text != modifierNomProduit || valuechangecmb != categoriedate.name.ToString())
                    {
                        MysqlConn.OpenDB();
                        MysqlConn.UpdateProducts(modifierIdProduit, txtnomproduit.Text, categoriedate.id);
                        MysqlConn.CloseDB();
                    }
                    MysqlConn.OpenDB();
                    MysqlConn.UpdateCommandeLines(modiferIdCommandeLines, int.Parse(txtQuantite.Text), txtDatePeremption.Text, unitesdata.id);
                    MysqlConn.CloseDB();
                    this.Hide();
                }
                else
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
                        MessageBox.Show("Votre produit a été ajouté dans le stock");
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
                        MessageBox.Show("Votre nouveau produit a été ajouté dans le stock et a été sauvegardé. Vous pouvez le reutiliser pour l'associer avec un ou plusieurs fournisseurs");
                    }
                }
            }


            else
            {
                MessageBox.Show("Remplir tous les champs obligatoires");
            }
        }

        private void PicReturne_Click_1(object sender, EventArgs e)
        {
            FrmStock formstock = new FrmStock();
            formstock.Show();
            this.Hide();
        }
    }
}
