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
        private void Actualizer()
        {
            dgvCommandeEnCours.Rows.Clear();
            MysqlConn.OpenDB();
            listSupplier = MysqlConn.ReadCommandes();
            foreach (CommandeLines value in listSupplier)
            {
                //Si la commande est pas arriver, status = 0
                if (value.Status == 0)
                {
                    dgvCommandeEnCours.Rows.Add(value.Id, value.Nameproduit, value.Quantity, value.Unities, "En cours", value.OrderDate);
                }
                //Si la commande est arriver, status = 2
                else
                {
                    dgvCommandeEnCours.Rows.Add(value.Id, value.Nameproduit, value.Quantity, value.Unities, "Commande arrivée", value.OrderDate);
                }

            }
            MysqlConn.CloseDB();
        }
        private void FrmMescommandes_Load(object sender, EventArgs e)
        {
            Actualizer();
        }

        private void dgvCommandeEnCours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvCommandeEnCours.SelectedCells)
            {
                if (dgvCommandeEnCours.Rows[e.RowIndex].Cells[4].Selected)
                {
                    string statusdonne = (string)dgvCommandeEnCours.Rows[oneCell.RowIndex].Cells[4].Value;

                    if (statusdonne == "En cours")
                    {
                        int id = (int)dgvCommandeEnCours.Rows[oneCell.RowIndex].Cells[0].Value;
                        MysqlConn.OpenDB();
                        MysqlConn.UpdateStatus(id);
                        MysqlConn.CloseDB();
                        Actualizer();


                    }
                }
            }
        }
    }
}
