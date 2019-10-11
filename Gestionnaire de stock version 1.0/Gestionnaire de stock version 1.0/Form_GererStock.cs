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
        Image imagedelet = Image.FromFile("P:/Projet (binôme)/Gestionnaire de stock version1.0/Gestionnaire de stock version 1.0/delete (1).png");
        Image imageedit = Image.FromFile("P:/Projet (binôme)/Gestionnaire de stock version1.0/Gestionnaire de stock version 1.0/edit.png");
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
                /* dgvStock.Rows[ligne].Cells[0].Value = value.id;
                  dgvStock.Rows[ligne].Cells[1].Value = value.nameproduit;
                  dgvStock.Rows[ligne].Cells[2].Value = value.categorie;
                  dgvStock.Rows[ligne].Cells[3].Value = value.quantity;
                  dgvStock.Rows[ligne].Cells[4].Value = value.peremption;
                  ligne++;*/
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
    }
}
