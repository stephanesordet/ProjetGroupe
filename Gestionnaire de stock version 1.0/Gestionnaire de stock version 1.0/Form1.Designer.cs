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
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlMenuper = new System.Windows.Forms.Panel();
            this.lblEditProduit = new System.Windows.Forms.Label();
            this.lblEditFournisseur = new System.Windows.Forms.Label();
            this.lblAjoutcategorie = new System.Windows.Forms.Label();
            this.picConfig = new System.Windows.Forms.PictureBox();
            this.picProduits = new System.Windows.Forms.PictureBox();
            this.picFournisseur = new System.Windows.Forms.PictureBox();
            this.picStock = new System.Windows.Forms.PictureBox();
            this.picCommander = new System.Windows.Forms.PictureBox();
            this.pnlMenuper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfig)).BeginInit();
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
            this.lblNomappli.Location = new System.Drawing.Point(230, 12);
            this.lblNomappli.Name = "lblNomappli";
            this.lblNomappli.Size = new System.Drawing.Size(271, 63);
            this.lblNomappli.TabIndex = 4;
            this.lblNomappli.Text = "Nom appli";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(10, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(170, 15);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Informations personelles ";
            this.lblInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMenuper
            // 
            this.pnlMenuper.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMenuper.Controls.Add(this.lblEditProduit);
            this.pnlMenuper.Controls.Add(this.lblEditFournisseur);
            this.pnlMenuper.Controls.Add(this.lblAjoutcategorie);
            this.pnlMenuper.Controls.Add(this.lblInfo);
            this.pnlMenuper.Location = new System.Drawing.Point(575, 55);
            this.pnlMenuper.Name = "pnlMenuper";
            this.pnlMenuper.Size = new System.Drawing.Size(180, 189);
            this.pnlMenuper.TabIndex = 7;
            // 
            // lblEditProduit
            // 
            this.lblEditProduit.AutoSize = true;
            this.lblEditProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProduit.Location = new System.Drawing.Point(10, 124);
            this.lblEditProduit.Name = "lblEditProduit";
            this.lblEditProduit.Size = new System.Drawing.Size(60, 15);
            this.lblEditProduit.TabIndex = 9;
            this.lblEditProduit.Text = "Produits";
            // 
            // lblEditFournisseur
            // 
            this.lblEditFournisseur.AutoSize = true;
            this.lblEditFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFournisseur.Location = new System.Drawing.Point(10, 85);
            this.lblEditFournisseur.Name = "lblEditFournisseur";
            this.lblEditFournisseur.Size = new System.Drawing.Size(90, 15);
            this.lblEditFournisseur.TabIndex = 8;
            this.lblEditFournisseur.Text = "Fournisseurs";
            this.lblEditFournisseur.Click += new System.EventHandler(this.lblModifieFournisseur_Click);
            // 
            // lblAjoutcategorie
            // 
            this.lblAjoutcategorie.AutoSize = true;
            this.lblAjoutcategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutcategorie.Location = new System.Drawing.Point(10, 48);
            this.lblAjoutcategorie.Name = "lblAjoutcategorie";
            this.lblAjoutcategorie.Size = new System.Drawing.Size(144, 15);
            this.lblAjoutcategorie.TabIndex = 7;
            this.lblAjoutcategorie.Text = "Ajouter une catégorie";
            this.lblAjoutcategorie.Click += new System.EventHandler(this.lblAjoutcategorie_Click);
            // 
            // picConfig
            // 
            this.picConfig.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.icons8_services_26;
            this.picConfig.Location = new System.Drawing.Point(702, 12);
            this.picConfig.Name = "picConfig";
            this.picConfig.Size = new System.Drawing.Size(53, 37);
            this.picConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfig.TabIndex = 5;
            this.picConfig.TabStop = false;
            this.picConfig.Click += new System.EventHandler(this.picconfig_Click);
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
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.pnlMenuper);
            this.Controls.Add(this.picConfig);
            this.Controls.Add(this.lblNomappli);
            this.Controls.Add(this.picProduits);
            this.Controls.Add(this.picFournisseur);
            this.Controls.Add(this.picStock);
            this.Controls.Add(this.picCommander);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlMenuper.ResumeLayout(false);
            this.pnlMenuper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfig)).EndInit();
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
        private System.Windows.Forms.PictureBox picConfig;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlMenuper;
        private System.Windows.Forms.Label lblAjoutcategorie;
        private System.Windows.Forms.Label lblEditProduit;
        private System.Windows.Forms.Label lblEditFournisseur;
    }
}

