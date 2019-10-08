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
    public partial class FrmCommande : Form
    {
        public FrmCommande()
        {
            InitializeComponent();
        }

        private void pic_returnemenu_Click(object sender, EventArgs e)
        {
            FrmMenu form1 = new FrmMenu();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmNouvellecommande form_nouvellecommande = new FrmNouvellecommande();
            form_nouvellecommande.Show();
            this.Hide();
        }

        private void picmescommandes_Click(object sender, EventArgs e)
        {
            FrmMescommandes form_Mescommandes = new FrmMescommandes();
            form_Mescommandes.Show();
            this.Hide();
        }
    }
}
