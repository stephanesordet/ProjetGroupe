namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmProduits
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
            this.Picretournemenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lstFournisseur = new System.Windows.Forms.ListBox();
            this.cmdValider = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picretournemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Picretournemenu
            // 
            this.Picretournemenu.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.Picretournemenu.Location = new System.Drawing.Point(2, 4);
            this.Picretournemenu.Name = "Picretournemenu";
            this.Picretournemenu.Size = new System.Drawing.Size(29, 28);
            this.Picretournemenu.TabIndex = 0;
            this.Picretournemenu.TabStop = false;
            this.Picretournemenu.Click += new System.EventHandler(this.Picretournemenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter un produit ";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(146, 77);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 27);
            this.txtNom.TabIndex = 2;
            // 
            // lstFournisseur
            // 
            this.lstFournisseur.FormattingEnabled = true;
            this.lstFournisseur.Location = new System.Drawing.Point(146, 175);
            this.lstFournisseur.Name = "lstFournisseur";
            this.lstFournisseur.Size = new System.Drawing.Size(150, 173);
            this.lstFournisseur.TabIndex = 4;
            // 
            // cmdValider
            // 
            this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValider.Location = new System.Drawing.Point(86, 378);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(160, 35);
            this.cmdValider.TabIndex = 5;
            this.cmdValider.Text = "valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(24, 77);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 22);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(24, 125);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(88, 22);
            this.lblCategorie.TabIndex = 7;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFournisseur.Location = new System.Drawing.Point(24, 175);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(105, 22);
            this.lblFournisseur.TabIndex = 8;
            this.lblFournisseur.Text = "Fournisseur";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(146, 125);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(150, 21);
            this.cmbCategorie.TabIndex = 9;

            // 
            // FrmProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.lstFournisseur);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picretournemenu);
            this.Name = "FrmProduits";
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.FrmProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picretournemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picretournemenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ListBox lstFournisseur;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.ComboBox cmbCategorie;
    }
}