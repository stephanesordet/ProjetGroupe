/**
 * \file      frmMenu.cs
 * \author    L. Kirchner Bannwart and S.Sordet 
 * \version   1.0
 * \date      Sep 11. 2019
 * \brief     Form to display the menu.
 *
 * \details   This form displays the menu. 
 */
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
    public partial class frmMenu : Form
    {
       
        public frmMenu()
        {
            InitializeComponent();
            Inicialisation();


        }

    

        public void Inicialisation()
        {
            pnlMenuper.Visible = false;
        }

        
        private void picCommander_Click(object sender, EventArgs e)
        {
          
            FrmCommande form_Commander = new FrmCommande();
            form_Commander.Show();
            this.Hide();

        }

        private void picStock_Click(object sender, EventArgs e)
        {
            frmStock form_stock = new frmStock();
            form_stock.Show();
            this.Hide();
        }

        private void picProduits_Click(object sender, EventArgs e)
        {
            frmProduits form_produits = new frmProduits();
            form_produits.Show();
            this.Hide();
        }

        private void picFournisseur_Click(object sender, EventArgs e)
        {
            frmFournisseur form_fournisseur = new frmFournisseur();
            form_fournisseur.Show();
            this.Hide();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            frmUtilisateur form_utilisateur = new frmUtilisateur();
            form_utilisateur.Show();
            this.Hide();
        }

        private void picconfig_Click(object sender, EventArgs e)
        {
            if (pnlMenuper.Visible == false)
            {
                pnlMenuper.Visible = true;
            }
            else
            {
                pnlMenuper.Visible = false;
            }

        }

        private void lblAjoutcategorie_Click(object sender, EventArgs e)
        {
            frmCategorie form_categorie = new frmCategorie();
            form_categorie.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
