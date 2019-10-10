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

namespace Gestionnaire_de_stock_version_1._0
{

    public partial class FrmNouvellecommande : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();
        Image imagedelet = Image.FromFile("P:/Projet (binôme)/Gestionnaire de stock version1.0/Gestionnaire de stock version 1.0/X.png");
        List<Unities> listUnities;
        List<Supplier> listSupplier;
        Supplier supplier;
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
            listSupplier = MysqlConn.ReadFournisseur();
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

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Image = imagedelet;
            img.Name = "Delet";
            //Add column header
            dataGridView1.Columns.Add(img);
            


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

            if (cboFournisseur.SelectedItem != null && cboProduit.SelectedItem != null && cboUnite.SelectedItem != null && txtQuantite.Text != "")
            {
                unitie = (Unities)cboUnite.SelectedItem;
                product = (Products)cboProduit.SelectedItem;
                string quantite = txtQuantite.Text;

                dataGridView1.Rows.Add(product, quantite, unitie);
                cboFournisseur.Enabled = false;
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[3].Selected)
                {
                   
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    
                }
                if(dataGridView1.Rows.Count < 2)
                {
                    cboFournisseur.Enabled = true;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.Text += "Bonjour ";
            //txtEmail.Text += supplier.gender.ToString();
            txtEmail.Text += supplier.firstName.ToString() +" " + supplier.lastName.ToString();
            int ligne = 0;
            for (int i=1; i<=dataGridView1.Rows.Count; i++)
            {
                txtEmail.Text += "\r\n";
                txtEmail.Text += dataGridView1.Rows[i-1].Cells[0].Value.ToString();
                txtEmail.Text += " ";
                txtEmail.Text += dataGridView1.Rows[i-1].Cells[1].Value.ToString();
                txtEmail.Text += " ";
                txtEmail.Text += dataGridView1.Rows[i-1].Cells[2].Value.ToString();

                ligne++;
            }
        }

        private void cmdFinierCommande_Click(object sender, EventArgs e)
        {
            int quantite = int.Parse(txtQuantite.Text);
            MysqlConn.OpenDB();
            int ligne = 0;
            for (int i = 2; i <= dataGridView1.Rows.Count; i++)
            {
                Products produitdata = (Products)dataGridView1.Rows[ligne].Cells[0].Value;
                string quantitedata =  dataGridView1.Rows[ligne].Cells[1].Value.ToString();
                int quantiteint = int.Parse(quantitedata);
                Unities unitesdata = (Unities)dataGridView1.Rows[ligne].Cells[2].Value;     
                MysqlConn.InsertCommandeLine(quantiteint, (int)produitdata.id, (int)unitesdata.id, (int)supplier.id, 0);
                ligne++;
            }
            MysqlConn.CloseDB();


            /*SmtpClient client = new SmtpClient();
            client.Port = 582;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential();
            MailAddress from = new MailAddress("Luana.KIRCHNER-BANNWART@cpnv.ch");
            MailAddress to = new MailAddress("luanabannwart@gmail.com");
            MailMessage message = new MailMessage(from,to);
            message.Body = "TEST";
            message.Subject = "test";
            message.Dispose();*/


        }
    }
}
