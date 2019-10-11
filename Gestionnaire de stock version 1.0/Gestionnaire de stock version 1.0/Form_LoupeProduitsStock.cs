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
    public partial class FrmLoupeProduitStcok : Form
    {
        FrmProduitStock formproduit;
        ConnectionDB MysqlConn = new ConnectionDB();
        public int idproduit;
        public FrmLoupeProduitStcok()
        {
            InitializeComponent();
        }

        private void cmdValidder_Click(object sender, EventArgs e)
        {
            formproduit = new FrmProduitStock();
            if (cboProduits.SelectedIndex != -1)
            {
                Products produit = (Products)cboProduits.SelectedItem;
                idproduit = (int)produit.id;
                this.Hide();
            }
            
        }

        private void FrmLoupeProduitStcok_Load(object sender, EventArgs e)
        {
            //Lire les Produits
            MysqlConn.OpenDB();
            List<Products> lisproduits = MysqlConn.ReadProducts();
            foreach (Products value in lisproduits)
            {
                cboProduits.Items.Add(value);
            }

            MysqlConn.CloseDB();

        }
    }
}
