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
        public FrmMescommandes()
        {
            InitializeComponent();
        }

        private void picretournemenu_Click(object sender, EventArgs e)
        {
            FrmCommander form_commander = new FrmCommander();
            form_commander.Show();
            this.Hide();
        }
    }
}
