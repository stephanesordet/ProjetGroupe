namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomappli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlmenuper = new System.Windows.Forms.Panel();
            this.picconfig = new System.Windows.Forms.PictureBox();
            this.picProduits = new System.Windows.Forms.PictureBox();
            this.picFournisseur = new System.Windows.Forms.PictureBox();
            this.picStock = new System.Windows.Forms.PictureBox();
            this.picCommander = new System.Windows.Forms.PictureBox();
            this.pnlmenuper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommander)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomappli
            // 
            this.lblNomappli.AutoSize = true;
            this.lblNomappli.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomappli.Location = new System.Drawing.Point(207, 9);
            this.lblNomappli.Name = "lblNomappli";
            this.lblNomappli.Size = new System.Drawing.Size(271, 63);
            this.lblNomappli.TabIndex = 4;
            this.lblNomappli.Text = "Nom appli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Informations personelles ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlmenuper
            // 
            this.pnlmenuper.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlmenuper.Controls.Add(this.label1);
            this.pnlmenuper.Location = new System.Drawing.Point(645, 79);
            this.pnlmenuper.Name = "pnlmenuper";
            this.pnlmenuper.Size = new System.Drawing.Size(152, 46);
            this.pnlmenuper.TabIndex = 7;
            // 
            // picconfig
            // 
            this.picconfig.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.icons8_services_26;
            this.picconfig.Location = new System.Drawing.Point(708, 24);
            this.picconfig.Name = "picconfig";
            this.picconfig.Size = new System.Drawing.Size(53, 37);
            this.picconfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picconfig.TabIndex = 5;
            this.picconfig.TabStop = false;
            this.picconfig.Click += new System.EventHandler(this.picconfig_Click);
            // 
            // picProduits
            // 
            this.picProduits.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.Produits;
            this.picProduits.Location = new System.Drawing.Point(377, 239);
            this.picProduits.Name = "picProduits";
            this.picProduits.Size = new System.Drawing.Size(192, 68);
            this.picProduits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProduits.TabIndex = 3;
            this.picProduits.TabStop = false;
            this.picProduits.Click += new System.EventHandler(this.picProduits_Click);
            // 
            // picFournisseur
            // 
            this.picFournisseur.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.Fournisseurs;
            this.picFournisseur.Location = new System.Drawing.Point(377, 311);
            this.picFournisseur.Name = "picFournisseur";
            this.picFournisseur.Size = new System.Drawing.Size(192, 99);
            this.picFournisseur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFournisseur.TabIndex = 2;
            this.picFournisseur.TabStop = false;
            this.picFournisseur.Click += new System.EventHandler(this.picFournisseur_Click);
            // 
            // picStock
            // 
            this.picStock.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.Stock;
            this.picStock.Location = new System.Drawing.Point(377, 103);
            this.picStock.Name = "picStock";
            this.picStock.Size = new System.Drawing.Size(192, 130);
            this.picStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStock.TabIndex = 1;
            this.picStock.TabStop = false;
            this.picStock.Click += new System.EventHandler(this.picStock_Click);
            // 
            // picCommander
            // 
            this.picCommander.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.Commander;
            this.picCommander.Location = new System.Drawing.Point(96, 103);
            this.picCommander.Name = "picCommander";
            this.picCommander.Size = new System.Drawing.Size(275, 204);
            this.picCommander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCommander.TabIndex = 0;
            this.picCommander.TabStop = false;
            this.picCommander.Click += new System.EventHandler(this.picCommander_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlmenuper);
            this.Controls.Add(this.picconfig);
            this.Controls.Add(this.lblNomappli);
            this.Controls.Add(this.picProduits);
            this.Controls.Add(this.picFournisseur);
            this.Controls.Add(this.picStock);
            this.Controls.Add(this.picCommander);
            this.Name = "FrmMenu";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlmenuper.ResumeLayout(false);
            this.pnlmenuper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommander)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCommander;
        private System.Windows.Forms.PictureBox picStock;
        private System.Windows.Forms.PictureBox picFournisseur;
        private System.Windows.Forms.PictureBox picProduits;
        private System.Windows.Forms.Label lblNomappli;
        private System.Windows.Forms.PictureBox picconfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlmenuper;
    }
}

