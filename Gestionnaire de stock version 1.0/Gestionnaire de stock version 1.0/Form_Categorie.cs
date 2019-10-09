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
    public partial class frmCategorie : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();
        public frmCategorie()
        {
            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmdVallider_Click(object sender, EventArgs e)
        {
            if(txtcategorie.Text != "")
            {
                MysqlConn.OpenDB();
                MysqlConn.InsertCategorie(txtcategorie.Text);
                MysqlConn.CloseDB();
            }
            else
            {
                MessageBox.Show("Entrez une categorie");
            }
        }
    }
}