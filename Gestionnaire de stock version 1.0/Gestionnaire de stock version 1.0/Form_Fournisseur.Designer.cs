namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmFournisseur
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
            this.pic_returnemenu = new System.Windows.Forms.PictureBox();
            this.lbljouterfornisseur = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEntreprise = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtNpa = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmdValider = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblNpa = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.chkM = new System.Windows.Forms.RadioButton();
            this.chkMme = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_returnemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_returnemenu
            // 
            this.pic_returnemenu.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.pic_returnemenu.Location = new System.Drawing.Point(4, 4);
            this.pic_returnemenu.Name = "pic_returnemenu";
            this.pic_returnemenu.Size = new System.Drawing.Size(27, 25);
            this.pic_returnemenu.TabIndex = 0;
            this.pic_returnemenu.TabStop = false;
            this.pic_returnemenu.Click += new System.EventHandler(this.pic_returnemenu_Click);
            // 
            // lbljouterfornisseur
            // 
            this.lbljouterfornisseur.AutoSize = true;
            this.lbljouterfornisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljouterfornisseur.Location = new System.Drawing.Point(48, 9);
            this.lbljouterfornisseur.Name = "lbljouterfornisseur";
            this.lbljouterfornisseur.Size = new System.Drawing.Size(271, 31);
            this.lbljouterfornisseur.TabIndex = 1;
            this.lbljouterfornisseur.Text = "Ajouter un fornisseur ";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(176, 115);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(143, 27);
            this.txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(176, 162);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(143, 27);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtEntreprise
            // 
            this.txtEntreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntreprise.Location = new System.Drawing.Point(176, 210);
            this.txtEntreprise.Name = "txtEntreprise";
            this.txtEntreprise.Size = new System.Drawing.Size(143, 27);
            this.txtEntreprise.TabIndex = 4;
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(176, 257);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(143, 27);
            this.txtVille.TabIndex = 5;
            // 
            // txtNpa
            // 
            this.txtNpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNpa.Location = new System.Drawing.Point(176, 306);
            this.txtNpa.Name = "txtNpa";
            this.txtNpa.Size = new System.Drawing.Size(143, 27);
            this.txtNpa.TabIndex = 6;
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.Location = new System.Drawing.Point(176, 361);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(143, 27);
            this.txtRue.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(176, 408);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // cmdValider
            // 
            this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValider.Location = new System.Drawing.Point(84, 480);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(167, 47);
            this.cmdValider.TabIndex = 9;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdvalider_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(50, 115);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 22);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(50, 162);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(72, 22);
            this.lblPrenom.TabIndex = 11;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.AutoSize = true;
            this.lblEntreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntreprise.Location = new System.Drawing.Point(50, 210);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(92, 22);
            this.lblEntreprise.TabIndex = 12;
            this.lblEntreprise.Text = "Entreprise";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(50, 257);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(44, 22);
            this.lblVille.TabIndex = 13;
            this.lblVille.Text = "Ville";
            // 
            // lblNpa
            // 
            this.lblNpa.AutoSize = true;
            this.lblNpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNpa.Location = new System.Drawing.Point(50, 306);
            this.lblNpa.Name = "lblNpa";
            this.lblNpa.Size = new System.Drawing.Size(47, 22);
            this.lblNpa.TabIndex = 14;
            this.lblNpa.Text = "NPA";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(50, 361);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(43, 22);
            this.lblRue.TabIndex = 15;
            this.lblRue.Text = "Rue";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 408);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 22);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // chkM
            // 
            this.chkM.AutoSize = true;
            this.chkM.Location = new System.Drawing.Point(71, 68);
            this.chkM.Name = "chkM";
            this.chkM.Size = new System.Drawing.Size(71, 17);
            this.chkM.TabIndex = 17;
            this.chkM.TabStop = true;
            this.chkM.Text = "Monsieur ";
            this.chkM.UseVisualStyleBackColor = true;
            // 
            // chkMme
            // 
            this.chkMme.AutoSize = true;
            this.chkMme.Location = new System.Drawing.Point(176, 68);
            this.chkMme.Name = "chkMme";
            this.chkMme.Size = new System.Drawing.Size(69, 17);
            this.chkMme.TabIndex = 18;
            this.chkMme.TabStop = true;
            this.chkMme.Text = "Madame ";
            this.chkMme.UseVisualStyleBackColor = true;
            // 
            // FrmFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 567);
            this.Controls.Add(this.chkMme);
            this.Controls.Add(this.chkM);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblNpa);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblEntreprise);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtNpa);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtEntreprise);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lbljouterfornisseur);
            this.Controls.Add(this.pic_returnemenu);
            this.Name = "FrmFournisseur";
            this.Text = "Fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.pic_returnemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_returnemenu;
        private System.Windows.Forms.Label lbljouterfornisseur;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEntreprise;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtNpa;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblNpa;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton chkM;
        private System.Windows.Forms.RadioButton chkMme;
    }
}