/**
 * \file      frmGererStock.cs
 * \author    L. Kirchner Bannwart and S.Sordet 
 * \version   1.0
 * \date      Oct 8. 2019
 * \brief     Form to display the stock.
 *
 * \details   This form displays the stock (product name, categorie, unities, quantiy, peremption). 
 */
using System;
using MySql.Data.MySqlClient;
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
    public partial class frmGererStock : Form
    {

        ConnectionDB MysqlConn = new ConnectionDB();
        Image imagedelet = Image.FromFile(Application.StartupPath + "/Images/delete (1).png");
        Image imageedit = Image.FromFile(Application.StartupPath + "/Images/edit.png");

        public bool modiferValide = false;
        public int idProduitModifer;
        public int quantiteModifer;
        public string categorieModifer;
        public string uniteModifer;
        public string nomProduitModifer;
        public string dateModifer; 
        public frmGererStock()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmStock formstock = new frmStock();
            formstock.Show();
            this.Hide();
        }
  
        private void Actualizer()
        {
            dgvStock.Rows.Clear();
            MysqlConn.OpenDB();
            List<CommandeLines> Listcommande = MysqlConn.ReadStock();
            foreach (CommandeLines value in Listcommande)
            {
                dgvStock.Rows.Add(value.Id, value.Nameproduit, value.Categorie, value.Quantity, value.Unities, value.Peremption);
            }
            MysqlConn.CloseDB();
           
        }
        private void FrmGererStock_Load(object sender, EventArgs e)
        {
            Actualizer();
            
            DataGridViewImageColumn imgdelet = new DataGridViewImageColumn();
            imgdelet.Image = imagedelet;
            imgdelet.Name = "Delet";
            //Add column header
            dgvStock.Columns.Add(imgdelet);
            DataGridViewImageColumn imgedit = new DataGridViewImageColumn();
            imgedit.Image = imageedit;
            imgedit.Name = "Edit";
            //Add column header
            dgvStock.Columns.Add(imgedit);
          
        }
        private void DgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvStock.SelectedCells)
            {
                //Clic sur edit 
                if (dgvStock.Rows[e.RowIndex].Cells[7].Selected)
                {
                    frmProduitStock formproduitstock = new frmProduitStock();
                    //Envoyer les informations du produit selectionnée dans le formulaire produitStock
                    formproduitstock.modifierProduit = true;
                    formproduitstock.modiferIdCommandeLines = (int)dgvStock.Rows[oneCell.RowIndex].Cells[0].Value;
                    formproduitstock.modifierNomProduit = (string)dgvStock.Rows[oneCell.RowIndex].Cells[1].Value;
                    formproduitstock.modiferCategorie = (string)dgvStock.Rows[oneCell.RowIndex].Cells[2].Value;
                    formproduitstock.modiferQuantite = (int)dgvStock.Rows[oneCell.RowIndex].Cells[3].Value;
                    formproduitstock.modiferUnite = (string)dgvStock.Rows[oneCell.RowIndex].Cells[4].Value;
                    formproduitstock.modiferDate = (string)dgvStock.Rows[oneCell.RowIndex].Cells[5].Value;
                    formproduitstock.ShowDialog();
                    Actualizer();
                }
                //Clic sur supprimer 
                if (dgvStock.Rows[e.RowIndex].Cells[6].Selected)
                {
                    DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer ce produit définitivement?", "Message de confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int id = (int)dgvStock.Rows[oneCell.RowIndex].Cells[0].Value;
                        MysqlConn.OpenDB();
                        MysqlConn.DeletInStock(id);
                        MysqlConn.CloseDB();
                        dgvStock.Rows.RemoveAt(oneCell.RowIndex);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }
        }
    }
}
