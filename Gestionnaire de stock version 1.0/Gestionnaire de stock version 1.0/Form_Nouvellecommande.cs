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

    public partial class FrmNouvellecommande : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();
        int selected = -1;
      
        List<Unities> listUnities;
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
            List<Supplier> listSupplier = MysqlConn.ReadFournisseur();
            foreach (Supplier value in listSupplier)
            {
                cboFournisseur.Items.Add(value);
            }
            MysqlConn.CloseDB();

            MysqlConn.OpenDB();
            listUnities = MysqlConn.ReadUnities();
            foreach (Unities value in listUnities)
            {
                cboUnite.Items.Add(value);
            }

            MysqlConn.CloseDB();

        }

        private void cboFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProduit.Items.Clear();
            MysqlConn.OpenDB();
            Supplier supplier = (Supplier)cboFournisseur.SelectedItem;
            List<Products> ListProducts = MysqlConn.ReadProductsHasSuppliers(supplier.id);
            foreach (Products value in ListProducts)
            {
                cboProduit.Items.Add(value);
            }

            MysqlConn.CloseDB();
            selected = cboFournisseur.SelectedIndex;
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            Unities unitie = (Unities)cboUnite.SelectedItem;
            Products product = (Products)cboProduit.SelectedItem;
            string quantite = txtQuantite.Text;

       
            dataGridView1.Rows.Add(product, quantite, unitie);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
    }
}
