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

            }
            MysqlConn.CloseDB();
        }

        private void dgvCommandeEnCours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvCommandeEnCours.SelectedCells)
            {
                if (dgvCommandeEnCours.Rows[e.RowIndex].Cells[4].Selected)
                {
                   int id = (int)dgvCommandeEnCours.Rows[oneCell.RowIndex].Cells[0].Value;
                    MysqlConn.OpenDB();
                    MysqlConn.UpdateStatus(id);
                    MysqlConn.CloseDB();
                    dgvCommandeEnCours.Rows.RemoveAt(oneCell.RowIndex);

                }
            }
        }
    }
}
