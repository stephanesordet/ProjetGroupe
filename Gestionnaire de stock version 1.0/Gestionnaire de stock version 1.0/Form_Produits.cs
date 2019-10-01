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
    public partial class FrmProduits : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();

      

        public FrmProduits()
        {
            InitializeComponent();
        }

        private void Picretournemenu_Click(object sender, EventArgs e)
        {
            FrmMenu form1 = new FrmMenu();
            form1.Show();
            this.Hide();
        }

        private void cmdvalider_Click(object sender, EventArgs e)
        {
            MysqlConn.OpenDB();
            MysqlConn.Insertcategories(txtnom.Text);
            MysqlConn.CloseDB();


        }

       

        private void FrmProduits_Load(object sender, EventArgs e)
        {
            MysqlConn.OpenDB();
      
            List<string> listvaluesRead = MysqlConn.ReadFournisseur();
            foreach(string value in listvaluesRead)
            {
                lstfournisseur.Items.Add(value);
            }
            MysqlConn.CloseDB();
        }

        
    }
}
