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
        public FrmNouvellecommande()
        {
            InitializeComponent();
        }

        private void picretourcommander_Click(object sender, EventArgs e)
        {
            FrmCommander forme_commander = new FrmCommander();
            forme_commander.Show();
            this.Hide();
        }
    }
}
