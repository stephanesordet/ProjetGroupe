namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmLoupeProduitStcok
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
            this.lstProduits = new System.Windows.Forms.ListBox();
            this.cmdValidder = new System.Windows.Forms.Button();
            this.picReturne = new System.Windows.Forms.PictureBox();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblProduits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picReturne)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProduits
            // 
            this.lstProduits.FormattingEnabled = true;
            this.lstProduits.Location = new System.Drawing.Point(47, 129);
            this.lstProduits.Name = "lstProduits";
            this.lstProduits.Size = new System.Drawing.Size(209, 277);
            this.lstProduits.TabIndex = 0;
            // 
            // cmdValidder
            // 
            this.cmdValidder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdValidder.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdValidder.Location = new System.Drawing.Point(47, 412);
            this.cmdValidder.Name = "cmdValidder";
            this.cmdValidder.Size = new System.Drawing.Size(209, 34);
            this.cmdValidder.TabIndex = 1;
            this.cmdValidder.Text = "Valider";
            this.cmdValidder.UseVisualStyleBackColor = false;
            this.cmdValidder.Click += new System.EventHandler(this.cmdValidder_Click);
            // 
            // picReturne
            // 
            this.picReturne.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picReturne.Location = new System.Drawing.Point(13, 13);
            this.picReturne.Name = "picReturne";
            this.picReturne.Size = new System.Drawing.Size(32, 34);
            this.picReturne.TabIndex = 2;
            this.picReturne.TabStop = false;
            this.picReturne.Click += new System.EventHandler(this.picReturne_Click);
            // 
            // cboCategorie
            // 
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(135, 82);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(121, 21);
            this.cboCategorie.TabIndex = 3;
            this.cboCategorie.SelectedIndexChanged += new System.EventHandler(this.cboCategorie_SelectedIndexChanged);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(44, 82);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(69, 17);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblProduits
            // 
            this.lblProduits.AutoSize = true;
            this.lblProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduits.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblProduits.Location = new System.Drawing.Point(93, 25);
            this.lblProduits.Name = "lblProduits";
            this.lblProduits.Size = new System.Drawing.Size(114, 31);
            this.lblProduits.TabIndex = 5;
            this.lblProduits.Text = "Produits";
            // 
            // FrmLoupeProduitStcok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 458);
            this.Controls.Add(this.lblProduits);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.cboCategorie);
            this.Controls.Add(this.picReturne);
            this.Controls.Add(this.cmdValidder);
            this.Controls.Add(this.lstProduits);
            this.Name = "FrmLoupeProduitStcok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoupeProduitStcok";
            this.Load += new System.EventHandler(this.FrmLoupeProduitStcok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picReturne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProduits;
        private System.Windows.Forms.Button cmdValidder;
        private System.Windows.Forms.PictureBox picReturne;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblProduits;
    }
}