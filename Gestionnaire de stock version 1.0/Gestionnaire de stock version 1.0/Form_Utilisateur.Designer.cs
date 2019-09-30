namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmUtilisateur
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
            this.picreturnemenu = new System.Windows.Forms.PictureBox();
            this.lblinfoperso = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEntreprise = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtNPA = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmdValider = new System.Windows.Forms.Button();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.lblentreprise = new System.Windows.Forms.Label();
            this.lblville = new System.Windows.Forms.Label();
            this.lblnpa = new System.Windows.Forms.Label();
            this.lblrue = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picreturnemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picreturnemenu
            // 
            this.picreturnemenu.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picreturnemenu.Location = new System.Drawing.Point(13, 13);
            this.picreturnemenu.Name = "picreturnemenu";
            this.picreturnemenu.Size = new System.Drawing.Size(28, 30);
            this.picreturnemenu.TabIndex = 0;
            this.picreturnemenu.TabStop = false;
            this.picreturnemenu.Click += new System.EventHandler(this.picreturnemenu_Click);
            // 
            // lblinfoperso
            // 
            this.lblinfoperso.AutoSize = true;
            this.lblinfoperso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfoperso.Location = new System.Drawing.Point(65, 13);
            this.lblinfoperso.Name = "lblinfoperso";
            this.lblinfoperso.Size = new System.Drawing.Size(228, 25);
            this.lblinfoperso.TabIndex = 1;
            this.lblinfoperso.Text = "Informations personelles ";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(137, 83);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(156, 27);
            this.txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(137, 125);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(156, 27);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtEntreprise
            // 
            this.txtEntreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntreprise.Location = new System.Drawing.Point(137, 169);
            this.txtEntreprise.Name = "txtEntreprise";
            this.txtEntreprise.Size = new System.Drawing.Size(156, 27);
            this.txtEntreprise.TabIndex = 4;
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(137, 215);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(156, 27);
            this.txtVille.TabIndex = 5;
            // 
            // txtNPA
            // 
            this.txtNPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPA.Location = new System.Drawing.Point(137, 262);
            this.txtNPA.Name = "txtNPA";
            this.txtNPA.Size = new System.Drawing.Size(156, 27);
            this.txtNPA.TabIndex = 6;
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.Location = new System.Drawing.Point(137, 309);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(156, 27);
            this.txtRue.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(137, 358);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // cmdValider
            // 
            this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValider.Location = new System.Drawing.Point(86, 423);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(159, 41);
            this.cmdValider.TabIndex = 9;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdvalider_Click);
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.Location = new System.Drawing.Point(82, 83);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(47, 22);
            this.lblnom.TabIndex = 10;
            this.lblnom.Text = "Nom";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprenom.Location = new System.Drawing.Point(57, 125);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(72, 22);
            this.lblprenom.TabIndex = 11;
            this.lblprenom.Text = "Prenom";
            // 
            // lblentreprise
            // 
            this.lblentreprise.AutoSize = true;
            this.lblentreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentreprise.Location = new System.Drawing.Point(39, 169);
            this.lblentreprise.Name = "lblentreprise";
            this.lblentreprise.Size = new System.Drawing.Size(92, 22);
            this.lblentreprise.TabIndex = 12;
            this.lblentreprise.Text = "Entreprise";
            // 
            // lblville
            // 
            this.lblville.AutoSize = true;
            this.lblville.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblville.Location = new System.Drawing.Point(85, 215);
            this.lblville.Name = "lblville";
            this.lblville.Size = new System.Drawing.Size(44, 22);
            this.lblville.TabIndex = 13;
            this.lblville.Text = "Ville";
            // 
            // lblnpa
            // 
            this.lblnpa.AutoSize = true;
            this.lblnpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnpa.Location = new System.Drawing.Point(82, 262);
            this.lblnpa.Name = "lblnpa";
            this.lblnpa.Size = new System.Drawing.Size(47, 22);
            this.lblnpa.TabIndex = 14;
            this.lblnpa.Text = "NPA";
            // 
            // lblrue
            // 
            this.lblrue.AutoSize = true;
            this.lblrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrue.Location = new System.Drawing.Point(86, 309);
            this.lblrue.Name = "lblrue";
            this.lblrue.Size = new System.Drawing.Size(43, 22);
            this.lblrue.TabIndex = 15;
            this.lblrue.Text = "Rue";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(75, 358);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(54, 22);
            this.lblemail.TabIndex = 16;
            this.lblemail.Text = "Email";
            // 
            // FrmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 490);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblrue);
            this.Controls.Add(this.lblnpa);
            this.Controls.Add(this.lblville);
            this.Controls.Add(this.lblentreprise);
            this.Controls.Add(this.lblprenom);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtNPA);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtEntreprise);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblinfoperso);
            this.Controls.Add(this.picreturnemenu);
            this.Name = "FrmUtilisateur";
            this.Text = "Informations personelles";
            ((System.ComponentModel.ISupportInitialize)(this.picreturnemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picreturnemenu;
        private System.Windows.Forms.Label lblinfoperso;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEntreprise;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtNPA;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lblentreprise;
        private System.Windows.Forms.Label lblville;
        private System.Windows.Forms.Label lblnpa;
        private System.Windows.Forms.Label lblrue;
        private System.Windows.Forms.Label lblemail;
    }
}