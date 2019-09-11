namespace Gestionnaire_de_stock_version_1._0
{
    partial class Form_Nouvellecommande
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
            this.txtproduit = new System.Windows.Forms.TextBox();
            this.cbofournisseur = new System.Windows.Forms.ComboBox();
            this.txtunite = new System.Windows.Forms.TextBox();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.lblproduit = new System.Windows.Forms.Label();
            this.lblunite = new System.Windows.Forms.Label();
            this.lblquantite = new System.Windows.Forms.Label();
            this.lblfournisseur = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmdvalider = new System.Windows.Forms.Button();
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
            // txtproduit
            // 
            this.txtproduit.Location = new System.Drawing.Point(454, 102);
            this.txtproduit.Name = "txtproduit";
            this.txtproduit.Size = new System.Drawing.Size(148, 20);
            this.txtproduit.TabIndex = 2;
            // 
            // cbofournisseur
            // 
            this.cbofournisseur.FormattingEnabled = true;
            this.cbofournisseur.Location = new System.Drawing.Point(170, 101);
            this.cbofournisseur.Name = "cbofournisseur";
            this.cbofournisseur.Size = new System.Drawing.Size(121, 21);
            this.cbofournisseur.TabIndex = 3;
            // 
            // txtunite
            // 
            this.txtunite.Location = new System.Drawing.Point(454, 138);
            this.txtunite.Name = "txtunite";
            this.txtunite.Size = new System.Drawing.Size(148, 20);
            this.txtunite.TabIndex = 4;
            // 
            // txtquantite
            // 
            this.txtquantite.Location = new System.Drawing.Point(170, 138);
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(121, 20);
            this.txtquantite.TabIndex = 5;
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
            // cmdvalider
            // 
            this.cmdvalider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdvalider.Location = new System.Drawing.Point(255, 193);
            this.cmdvalider.Name = "cmdvalider";
            this.cmdvalider.Size = new System.Drawing.Size(126, 31);
            this.cmdvalider.TabIndex = 10;
            this.cmdvalider.Text = "Valider";
            this.cmdvalider.UseVisualStyleBackColor = true;
            // 
            // Form_Nouvellecommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.cmdvalider);
            this.Controls.Add(this.lblfournisseur);
            this.Controls.Add(this.lblquantite);
            this.Controls.Add(this.lblunite);
            this.Controls.Add(this.lblproduit);
            this.Controls.Add(this.txtquantite);
            this.Controls.Add(this.txtunite);
            this.Controls.Add(this.cbofournisseur);
            this.Controls.Add(this.txtproduit);
            this.Controls.Add(this.picretourcommander);
            this.Controls.Add(this.lblcommande);
            this.Name = "Form_Nouvellecommande";
            this.Text = "Form_Nouvellecommande";
            ((System.ComponentModel.ISupportInitialize)(this.picretourcommander)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcommande;
        private System.Windows.Forms.PictureBox picretourcommander;
        private System.Windows.Forms.TextBox txtproduit;
        private System.Windows.Forms.ComboBox cbofournisseur;
        private System.Windows.Forms.TextBox txtunite;
        private System.Windows.Forms.TextBox txtquantite;
        private System.Windows.Forms.Label lblproduit;
        private System.Windows.Forms.Label lblunite;
        private System.Windows.Forms.Label lblquantite;
        private System.Windows.Forms.Label lblfournisseur;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cmdvalider;
    }
}