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
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        private void picRetourneMenu_Click(object sender, EventArgs e)
        {
            FrmMenu form1 = new FrmMenu();
            form1.Show();
            this.Hide();
        }

        private void picGererStock_Click(object sender, EventArgs e)
        {
            FrmGererStock formgererstock = new FrmGererStock();
            formgererstock.Show();
            this.Hide();
        }
        private void PicAjouterproduit_Click(object sender, EventArgs e)
        {
            FrmProduitStock formproduitsctok = new FrmProduitStock();
            formproduitsctok.Show();
            this.Hide();
        }
    }
}
