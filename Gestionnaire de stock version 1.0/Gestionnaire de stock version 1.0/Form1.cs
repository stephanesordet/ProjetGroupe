﻿using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void picCommander_Click(object sender, EventArgs e)
        {
          
            Form_Commander form_Commander = new Form_Commander();
            form_Commander.Show();
            this.Hide();

        }
    }
}