namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmProduitStock
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
            this.lblProduitStcok = new System.Windows.Forms.Label();
            this.txtnomproduit = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmbUnites = new System.Windows.Forms.ComboBox();
            this.txtDatePeremption = new System.Windows.Forms.TextBox();
            this.cmdValider = new System.Windows.Forms.Button();
            this.lblProduit = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.picLoupProuduits = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnite = new System.Windows.Forms.Label();
            this.lblPeremption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLoupProuduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduitStcok
            // 
            this.lblProduitStcok.AutoSize = true;
            this.lblProduitStcok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduitStcok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProduitStcok.Location = new System.Drawing.Point(81, 31);
            this.lblProduitStcok.Name = "lblProduitStcok";
            this.lblProduitStcok.Size = new System.Drawing.Size(268, 25);
            this.lblProduitStcok.TabIndex = 0;
            this.lblProduitStcok.Text = "Ajouter un produit dans Stcok";
            // 
            // txtnomproduit
            // 
            this.txtnomproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomproduit.Location = new System.Drawing.Point(176, 98);
            this.txtnomproduit.Name = "txtnomproduit";
            this.txtnomproduit.Size = new System.Drawing.Size(150, 23);
            this.txtnomproduit.TabIndex = 1;
            this.txtnomproduit.TextChanged += new System.EventHandler(this.txtnomproduit_TextChanged);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantite.Location = new System.Drawing.Point(176, 203);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(150, 23);
            this.txtQuantite.TabIndex = 4;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(176, 152);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(150, 24);
            this.cmbCategorie.TabIndex = 5;
            // 
            // cmbUnites
            // 
            this.cmbUnites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnites.FormattingEnabled = true;
            this.cmbUnites.Location = new System.Drawing.Point(176, 252);
            this.cmbUnites.Name = "cmbUnites";
            this.cmbUnites.Size = new System.Drawing.Size(150, 24);
            this.cmbUnites.TabIndex = 6;
            // 
            // txtDatePeremption
            // 
            this.txtDatePeremption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatePeremption.Location = new System.Drawing.Point(176, 306);
            this.txtDatePeremption.Name = "txtDatePeremption";
            this.txtDatePeremption.Size = new System.Drawing.Size(150, 23);
            this.txtDatePeremption.TabIndex = 8;
            // 
            // cmdValider
            // 
            this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValider.ForeColor = System.Drawing.Color.Snow;
            this.cmdValider.Location = new System.Drawing.Point(117, 353);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(173, 38);
            this.cmdValider.TabIndex = 9;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = false;
            this.cmdValider.Click += new System.EventHandler(this.CmdValider_Click);
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduit.Location = new System.Drawing.Point(39, 98);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(131, 20);
            this.lblProduit.TabIndex = 10;
            this.lblProduit.Text = "Nom du produit  *";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(82, 156);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(88, 20);
            this.lblCategorie.TabIndex = 11;
            this.lblCategorie.Text = "Categorie *";
            // 
            // picLoupProuduits
            // 
            this.picLoupProuduits.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.loupe;
            this.picLoupProuduits.Location = new System.Drawing.Point(337, 98);
            this.picLoupProuduits.Name = "picLoupProuduits";
            this.picLoupProuduits.Size = new System.Drawing.Size(43, 23);
            this.picLoupProuduits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoupProuduits.TabIndex = 7;
            this.picLoupProuduits.TabStop = false;
            this.picLoupProuduits.Click += new System.EventHandler(this.picLoupProuduits_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 26);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(90, 206);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 20);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantite *";
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnite.Location = new System.Drawing.Point(113, 256);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(57, 20);
            this.lblUnite.TabIndex = 13;
            this.lblUnite.Text = "Unité *";
            // 
            // lblPeremption
            // 
            this.lblPeremption.AutoSize = true;
            this.lblPeremption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeremption.Location = new System.Drawing.Point(23, 306);
            this.lblPeremption.Name = "lblPeremption";
            this.lblPeremption.Size = new System.Drawing.Size(147, 20);
            this.lblPeremption.TabIndex = 14;
            this.lblPeremption.Text = "date de péremption";
            // 
            // FrmProduitStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 417);
            this.Controls.Add(this.lblPeremption);
            this.Controls.Add(this.lblUnite);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblProduit);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.txtDatePeremption);
            this.Controls.Add(this.picLoupProuduits);
            this.Controls.Add(this.cmbUnites);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtnomproduit);
            this.Controls.Add(this.lblProduitStcok);
            this.Name = "FrmProduitStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ProduitStock";
            this.Load += new System.EventHandler(this.FrmProduitStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoupProuduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduitStcok;
        private System.Windows.Forms.TextBox txtnomproduit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.ComboBox cmbUnites;
        private System.Windows.Forms.PictureBox picLoupProuduits;
        private System.Windows.Forms.TextBox txtDatePeremption;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.Label lblPeremption;
    }
}