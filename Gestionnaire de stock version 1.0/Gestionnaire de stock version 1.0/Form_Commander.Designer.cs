﻿namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmCommander
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picNouvelleCommande = new System.Windows.Forms.PictureBox();
            this.picMescommandes = new System.Windows.Forms.PictureBox();
            this.pic_returnemenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNouvelleCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMescommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_returnemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picNouvelleCommande
            // 
            this.picNouvelleCommande.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.nouvellecommande;
            this.picNouvelleCommande.Location = new System.Drawing.Point(44, 188);
            this.picNouvelleCommande.Name = "picNouvelleCommande";
            this.picNouvelleCommande.Size = new System.Drawing.Size(300, 104);
            this.picNouvelleCommande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNouvelleCommande.TabIndex = 2;
            this.picNouvelleCommande.TabStop = false;
            this.picNouvelleCommande.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picMescommandes
            // 
            this.picMescommandes.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.Mescommandes;
            this.picMescommandes.Location = new System.Drawing.Point(44, 66);
            this.picMescommandes.Name = "picMescommandes";
            this.picMescommandes.Size = new System.Drawing.Size(300, 100);
            this.picMescommandes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMescommandes.TabIndex = 1;
            this.picMescommandes.TabStop = false;
            this.picMescommandes.Click += new System.EventHandler(this.picmescommandes_Click);
            // 
            // pic_returnemenu
            // 
            this.pic_returnemenu.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.pic_returnemenu.Location = new System.Drawing.Point(13, 13);
            this.pic_returnemenu.Name = "pic_returnemenu";
            this.pic_returnemenu.Size = new System.Drawing.Size(31, 26);
            this.pic_returnemenu.TabIndex = 0;
            this.pic_returnemenu.TabStop = false;
            this.pic_returnemenu.Click += new System.EventHandler(this.pic_returnemenu_Click);
            // 
            // FrmCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 336);
            this.Controls.Add(this.picNouvelleCommande);
            this.Controls.Add(this.picMescommandes);
            this.Controls.Add(this.pic_returnemenu);
            this.Name = "FrmCommander";
            this.Text = "Commander";
            ((System.ComponentModel.ISupportInitialize)(this.picNouvelleCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMescommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_returnemenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_returnemenu;
        private System.Windows.Forms.PictureBox picMescommandes;
        private System.Windows.Forms.PictureBox picNouvelleCommande;
    }
}