namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmNouvellecommande
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
            this.lblcommande = new System.Windows.Forms.Label();
            this.picretourcommander = new System.Windows.Forms.PictureBox();
            this.cboFournisseurComm = new System.Windows.Forms.ComboBox();
            this.lblproduit = new System.Windows.Forms.Label();
            this.lblunite = new System.Windows.Forms.Label();
            this.lblquantite = new System.Windows.Forms.Label();
            this.lblfournisseur = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmdValider = new System.Windows.Forms.Button();
            this.cboProduitComm = new System.Windows.Forms.ComboBox();
            this.cboUnitéComm = new System.Windows.Forms.ComboBox();
            this.txtQuantitéComm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picretourcommander)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcommande
            // 
            this.lblcommande.AutoSize = true;
            this.lblcommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcommande.Location = new System.Drawing.Point(249, 9);
            this.lblcommande.Name = "lblcommande";
            this.lblcommande.Size = new System.Drawing.Size(153, 31);
            this.lblcommande.TabIndex = 0;
            this.lblcommande.Text = "Commande";
            // 
            // picretourcommander
            // 
            this.picretourcommander.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picretourcommander.Location = new System.Drawing.Point(13, 13);
            this.picretourcommander.Name = "picretourcommander";
            this.picretourcommander.Size = new System.Drawing.Size(34, 33);
            this.picretourcommander.TabIndex = 1;
            this.picretourcommander.TabStop = false;
            this.picretourcommander.Click += new System.EventHandler(this.picretourcommander_Click);
            // 
            // cboFournisseurComm
            // 
            this.cboFournisseurComm.FormattingEnabled = true;
            this.cboFournisseurComm.Location = new System.Drawing.Point(170, 101);
            this.cboFournisseurComm.Name = "cboFournisseurComm";
            this.cboFournisseurComm.Size = new System.Drawing.Size(121, 21);
            this.cboFournisseurComm.TabIndex = 3;
            // 
            // lblproduit
            // 
            this.lblproduit.AutoSize = true;
            this.lblproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduit.Location = new System.Drawing.Point(372, 103);
            this.lblproduit.Name = "lblproduit";
            this.lblproduit.Size = new System.Drawing.Size(63, 20);
            this.lblproduit.TabIndex = 6;
            this.lblproduit.Text = "Produit ";
            // 
            // lblunite
            // 
            this.lblunite.AutoSize = true;
            this.lblunite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunite.Location = new System.Drawing.Point(372, 138);
            this.lblunite.Name = "lblunite";
            this.lblunite.Size = new System.Drawing.Size(47, 20);
            this.lblunite.TabIndex = 7;
            this.lblunite.Text = "Unite";
            // 
            // lblquantite
            // 
            this.lblquantite.AutoSize = true;
            this.lblquantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantite.Location = new System.Drawing.Point(43, 136);
            this.lblquantite.Name = "lblquantite";
            this.lblquantite.Size = new System.Drawing.Size(70, 20);
            this.lblquantite.TabIndex = 8;
            this.lblquantite.Text = "Quantité";
            // 
            // lblfournisseur
            // 
            this.lblfournisseur.AutoSize = true;
            this.lblfournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfournisseur.Location = new System.Drawing.Point(43, 101);
            this.lblfournisseur.Name = "lblfournisseur";
            this.lblfournisseur.Size = new System.Drawing.Size(93, 20);
            this.lblfournisseur.TabIndex = 9;
            this.lblfournisseur.Text = "Fournisseur";
            // 
            // cmdValider
            // 
            this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValider.Location = new System.Drawing.Point(255, 193);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(126, 31);
            this.cmdValider.TabIndex = 10;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            // 
            // cboProduitComm
            // 
            this.cboProduitComm.FormattingEnabled = true;
            this.cboProduitComm.Location = new System.Drawing.Point(455, 100);
            this.cboProduitComm.Name = "cboProduitComm";
            this.cboProduitComm.Size = new System.Drawing.Size(121, 21);
            this.cboProduitComm.TabIndex = 3;
            // 
            // cboUnitéComm
            // 
            this.cboUnitéComm.FormattingEnabled = true;
            this.cboUnitéComm.Location = new System.Drawing.Point(455, 140);
            this.cboUnitéComm.Name = "cboUnitéComm";
            this.cboUnitéComm.Size = new System.Drawing.Size(121, 21);
            this.cboUnitéComm.TabIndex = 3;
            // 
            // txtQuantitéComm
            // 
            this.txtQuantitéComm.Location = new System.Drawing.Point(170, 140);
            this.txtQuantitéComm.Name = "txtQuantitéComm";
            this.txtQuantitéComm.Size = new System.Drawing.Size(121, 20);
            this.txtQuantitéComm.TabIndex = 11;
            // 
            // FrmNouvellecommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.txtQuantitéComm);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.lblfournisseur);
            this.Controls.Add(this.lblquantite);
            this.Controls.Add(this.lblunite);
            this.Controls.Add(this.lblproduit);
            this.Controls.Add(this.cboUnitéComm);
            this.Controls.Add(this.cboProduitComm);
            this.Controls.Add(this.cboFournisseurComm);
            this.Controls.Add(this.picretourcommander);
            this.Controls.Add(this.lblcommande);
            this.Name = "FrmNouvellecommande";
            this.Text = "Nouvellecommande";
            ((System.ComponentModel.ISupportInitialize)(this.picretourcommander)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcommande;
        private System.Windows.Forms.PictureBox picretourcommander;
        private System.Windows.Forms.ComboBox cboFournisseurComm;
        private System.Windows.Forms.Label lblproduit;
        private System.Windows.Forms.Label lblunite;
        private System.Windows.Forms.Label lblquantite;
        private System.Windows.Forms.Label lblfournisseur;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.ComboBox cboProduitComm;
        private System.Windows.Forms.ComboBox cboUnitéComm;
        private System.Windows.Forms.TextBox txtQuantitéComm;
    }
}