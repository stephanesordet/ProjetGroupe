﻿/**
 * \file      frmCategorie.cs
 * \author    L. Kirchner Bannwart and S.Sordet 
 * \version   1.0
 * \date      September 11. 2019
 * \brief     Form to enter data about the categories.
 *
 * \details   This form enables to enter data about the categories (name).
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
    public partial class frmCategorie : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();
        public frmCategorie()
        {
            InitializeComponent();
          
        }

        private void cmdVallider_Click(object sender, EventArgs e)
        {
            //Inserer la categorie dans la basse 
            if(txtcategorie.Text != "")
            {
                //Controler le text box 
                int returnCarac = Controller.characterController(txtcategorie.Text);
                if (returnCarac == 1)
                {
                    MessageBox.Show("Erreur! Vous avez entrée un caractér special");
                }
                else
                {
                    MysqlConn.OpenDB();
                    MysqlConn.InsertCategorie(txtcategorie.Text);
                    MysqlConn.CloseDB();
                }
            }
            else
            {
                MessageBox.Show("Entrez une categorie");
            }
        }

        private void picReturne_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCategorie_Load(object sender, EventArgs e)
        {

        }
    }
}
