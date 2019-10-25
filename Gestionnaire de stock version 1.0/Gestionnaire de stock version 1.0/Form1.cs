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
    public partial class FrmMenu : Form
    {
       
        public FrmMenu()
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
            FrmStock form_stock = new FrmStock();
            form_stock.Show();
            this.Hide();
        }

        private void picProduits_Click(object sender, EventArgs e)
        {
            FrmProduits form_produits = new FrmProduits();
            form_produits.Show();
            this.Hide();
        }

        private void picFournisseur_Click(object sender, EventArgs e)
        {
            FrmFournisseur form_fournisseur = new FrmFournisseur();
            form_fournisseur.Show();
            this.Hide();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            FrmUtilisateur form_utilisateur = new FrmUtilisateur();
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


    }
}
