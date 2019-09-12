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
    public partial class Form_Mescommandes : Form
    {
        public Form_Mescommandes()
        {
            InitializeComponent();
        }

        private void picretournemenu_Click(object sender, EventArgs e)
        {
            Form_Commander form_commander = new Form_Commander();
            form_commander.Show();
            this.Hide();
        }
    }
}
