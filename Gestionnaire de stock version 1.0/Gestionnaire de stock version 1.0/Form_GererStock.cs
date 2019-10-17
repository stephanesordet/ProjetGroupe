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
    public partial class FrmGererStock : Form
    {

        ConnectionDB MysqlConn = new ConnectionDB();
        Image imagedelet = Image.FromFile("L:/Gestionnaire 1.0/Gestionnaire de stock version 1.0/delete (1).png");
        Image imageedit = Image.FromFile("L:/Gestionnaire 1.0/Gestionnaire de stock version 1.0/edit.png");
        public FrmGererStock()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmStock formstock = new FrmStock();
            formstock.Show();
            this.Hide();
        }

        private void FrmGererStock_Load(object sender, EventArgs e)
        {
            MysqlConn.OpenDB();
            List<CommandeLines> listSupplier = MysqlConn.ReadStock();
            int ligne = 1;
            foreach (CommandeLines value in listSupplier)
            {

                dgvStock.Rows.Add(value.id, value.nameproduit, value.categorie, value.quantity, value.unities, value.peremption);
            }

            MysqlConn.CloseDB();
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
                if (dgvStock.Rows[e.RowIndex].Cells[6].Selected)
                {
                    DialogResult dialogResult = MessageBox.Show("Vous voulez supprimer ce produit définitivement?", "Message de confirmation",  MessageBoxButtons.YesNo);
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
