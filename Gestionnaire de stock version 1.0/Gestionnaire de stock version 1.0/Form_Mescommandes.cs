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
    public partial class FrmMescommandes : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();
        List<CommandeLines> listSupplier;
        public FrmMescommandes()
        {
            InitializeComponent();
        }

        private void picretournemenu_Click(object sender, EventArgs e)
        {
            FrmCommande form_commander = new FrmCommande();
            form_commander.Show();
            this.Hide();
        }

        private void FrmMescommandes_Load(object sender, EventArgs e)
        {
            MysqlConn.OpenDB();
            listSupplier = MysqlConn.ReadCommandes();
            int ligne = 1;
            foreach (CommandeLines value in listSupplier)
            {

                dgvCommandeEnCours.Rows.Add(value.id, value.nameproduit, value.quantity, value.unities, "En cours", value.orderDate);
                /* dgvStock.Rows[ligne].Cells[0].Value = value.id;
                  dgvStock.Rows[ligne].Cells[1].Value = value.nameproduit;
                  dgvStock.Rows[ligne].Cells[2].Value = value.categorie;
                  dgvStock.Rows[ligne].Cells[3].Value = value.quantity;
                  dgvStock.Rows[ligne].Cells[4].Value = value.peremption;
                  ligne++;*/
            }
            MysqlConn.CloseDB();
        }

        private void dgvCommandeEnCours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvCommandeEnCours.SelectedCells)
            {
                if (dgvCommandeEnCours.Rows[e.RowIndex].Cells[4].Selected)
                {
                    //UPDATE
                }
            }
        }
    }
}
