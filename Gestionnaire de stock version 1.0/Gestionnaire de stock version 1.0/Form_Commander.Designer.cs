namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmCommande
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
            this.picMesCommandes = new System.Windows.Forms.PictureBox();
            this.pic_returnemenu = new System.Windows.Forms.PictureBox();
            this.lblComande = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNouvelleCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMesCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_returnemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picNouvelleCommande
            // 
            this.picNouvelleCommande.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.nouvellecommande;
            this.picNouvelleCommande.Location = new System.Drawing.Point(142, 229);
            this.picNouvelleCommande.Name = "picNouvelleCommande";
            this.picNouvelleCommande.Size = new System.Drawing.Size(300, 104);
            this.picNouvelleCommande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNouvelleCommande.TabIndex = 2;
            this.picNouvelleCommande.TabStop = false;
            this.picNouvelleCommande.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picMesCommandes
            // 
            this.picMesCommandes.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.Mescommandes;
            this.picMesCommandes.Location = new System.Drawing.Point(142, 100);
            this.picMesCommandes.Name = "picMesCommandes";
            this.picMesCommandes.Size = new System.Drawing.Size(300, 100);
            this.picMesCommandes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMesCommandes.TabIndex = 1;
            this.picMesCommandes.TabStop = false;
            this.picMesCommandes.Click += new System.EventHandler(this.picmescommandes_Click);
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
            // lblComande
            // 
            this.lblComande.AutoSize = true;
            this.lblComande.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComande.Location = new System.Drawing.Point(191, 13);
            this.lblComande.Name = "lblComande";
            this.lblComande.Size = new System.Drawing.Size(193, 39);
            this.lblComande.TabIndex = 3;
            this.lblComande.Text = "Commande";
            this.lblComande.Click += new System.EventHandler(this.lblComande_Click);
            // 
            // FrmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 394);
            this.Controls.Add(this.lblComande);
            this.Controls.Add(this.picNouvelleCommande);
            this.Controls.Add(this.picMesCommandes);
            this.Controls.Add(this.pic_returnemenu);
            this.Name = "FrmCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commande";
            ((System.ComponentModel.ISupportInitialize)(this.picNouvelleCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMesCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_returnemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_returnemenu;
        private System.Windows.Forms.PictureBox picMesCommandes;
        private System.Windows.Forms.PictureBox picNouvelleCommande;
        private System.Windows.Forms.Label lblComande;
    }
}