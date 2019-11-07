/**
 * \file      frmStock.cs
 * \author    L. Kirchner Bannwart and S.Sordet 
 * \version   1.0
 * \date      Sep 11. 2019
 * \brief     Form to display the menu to stock.
 *
 * \details   This form displays the menu to stock. 
 */
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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void picRetourneMenu_Click(object sender, EventArgs e)
        {
            frmMenu form1 = new frmMenu();
            form1.Show();
            this.Hide();
        }

        private void picGererStock_Click(object sender, EventArgs e)
        {
            frmGererStock formgererstock = new frmGererStock();
            formgererstock.Show();
            this.Hide();
        }
        private void PicAjouterproduit_Click(object sender, EventArgs e)
        {
            frmProduitStock formproduitsctok = new frmProduitStock();
            formproduitsctok.Show();
            this.Hide();
        }
    }
}
