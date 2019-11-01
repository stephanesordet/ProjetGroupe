using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestionnaire_de_stock_version_1._0
{

    public partial class FrmNouvellecommande : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();
        Image imagedelet = Image.FromFile("C:/2ème_année/Projet (binôme)/Gestionnaire de stock version 1.0/X.png");
        List<Unities> listUnities;
        List<Supplier> listSupplier;
        Supplier supplier;
        User user;
        Unities unitie;
        Products product;
        public FrmNouvellecommande()
        {
            InitializeComponent();
        }

        private void picretourcommander_Click(object sender, EventArgs e)
        {
            FrmCommande forme_commander = new FrmCommande();
            forme_commander.Show();
            this.Hide();
        }

        private void FrmNouvellecommande_Load(object sender, EventArgs e)
        {
            MysqlConn.OpenDB();
            //Lire les fournisseur 
            listSupplier = MysqlConn.ReadSuplliers();
            foreach (Supplier value in listSupplier)
            {
                cboFournisseur.Items.Add(value);
            }
            MysqlConn.CloseDB();
            
            //Lire les unites
            MysqlConn.OpenDB();
            listUnities = MysqlConn.ReadUnities();
            foreach (Unities value in listUnities)
            {
                cboUnite.Items.Add(value);
            }

            MysqlConn.CloseDB();

            //Add le image delete
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Image = imagedelet;
            img.Name = "Delet";
            //Add column header
            dgvcommande.Columns.Add(img);
            


        }

        private void cboFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProduit.Items.Clear();
            MysqlConn.OpenDB();
            supplier = (Supplier)cboFournisseur.SelectedItem;
            List<Products> ListProducts = MysqlConn.ReadProductsHasSuppliers(supplier.id);
            foreach (Products value in ListProducts)
            {
                cboProduit.Items.Add(value);
            }

            MysqlConn.CloseDB();
            
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            //Si tous les champs du formulaire sont remplissent
            if (cboFournisseur.SelectedItem != null && cboProduit.SelectedItem != null && cboUnite.SelectedItem != null && txtQuantite.Text != "")
            {
                unitie = (Unities)cboUnite.SelectedItem;
                product = (Products)cboProduit.SelectedItem;
                string quantite = txtQuantite.Text;
                //Add le produit dans le tableau commande 
                dgvcommande.Rows.Add(product, quantite, unitie);
                cboFournisseur.Enabled = false;
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void dgvcommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvcommande.SelectedCells)
            {
                //Si l'utilisateur à clique sur le bouton delet
                if (dgvcommande.Rows[e.RowIndex].Cells[3].Selected)
                {
                        //Supprimer la ligne selectionné
                        dgvcommande.Rows.RemoveAt(oneCell.RowIndex);
                    
                }
                //Si il existe plus que 1 produit dans le tableau
                if(dgvcommande.Rows.Count < 2)
                {
                    cboFournisseur.Enabled = true;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.Text += "Bonjour ";
        
            txtEmail.Text += supplier.gender.ToString() +" " + supplier.lastName.ToString() + " voici la commande.";
            int ligne = 0;
            for (int i=1; i<=dgvcommande.Rows.Count; i++)
            {
                txtEmail.Text += "\r\n";
                txtEmail.Text += "\r\n";
                txtEmail.Text += dgvcommande.Rows[i-1].Cells[0].Value.ToString();
                txtEmail.Text += " ";
                txtEmail.Text += dgvcommande.Rows[i-1].Cells[1].Value.ToString();
                txtEmail.Text += " ";
                txtEmail.Text += dgvcommande.Rows[i-1].Cells[2].Value.ToString();

                ligne++;
            }
        }

        private void cmdFinierCommande_Click(object sender, EventArgs e)
        {
            int quantite = int.Parse(txtQuantite.Text);
            MysqlConn.OpenDB();
            int ligne = 0;
            for (int i = 1; i <= dgvcommande.Rows.Count; i++)
            {
                Products produitdata = (Products)dgvcommande.Rows[i-1].Cells[0].Value;
                string quantitedata =  dgvcommande.Rows[i-1].Cells[1].Value.ToString();
                int quantiteint = int.Parse(quantitedata);
                Unities unitesdata = (Unities)dgvcommande.Rows[i-1].Cells[2].Value;     
                MysqlConn.InsertCommandeLine(quantiteint, (int)produitdata.id, (int)unitesdata.id, (int)supplier.id, 0);
                ligne++;
            }
            MysqlConn.CloseDB();
            
            //Déclaration de l'objet newMail
            Mail newMail;

            newMail = new Mail("Stephane.sordet@cpnv.ch", supplier.email, "", txtEmail.Text);
            //Envoie de l'email
            MysqlConn.sendMail(newMail);
           

            MessageBox.Show("Votre commande à bien été envoyée");
            txtQuantite.Text = "";
            dgvcommande.Rows.Clear();
            txtEmail.Text = "";
            cboFournisseur.Enabled = true;

        }
    }
}
