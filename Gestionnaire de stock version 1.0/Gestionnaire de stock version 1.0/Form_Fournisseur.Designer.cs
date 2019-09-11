namespace Gestionnaire_de_stock_version_1._0
{
    partial class Form_Fournisseur
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
            this.lbljouterfornisseur.Location = new System.Drawing.Point(138, 9);
            this.lbljouterfornisseur.Name = "lbljouterfornisseur";
            this.lbljouterfornisseur.Size = new System.Drawing.Size(271, 31);
            this.lbljouterfornisseur.TabIndex = 1;
            this.lbljouterfornisseur.Text = "Ajouter un fornisseur ";
            // 
            // Form_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 567);
            this.Controls.Add(this.lbljouterfornisseur);
            this.Controls.Add(this.pic_returnemenu);
            this.Name = "Form_Fournisseur";
            this.Text = "Form_Fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.pic_returnemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_returnemenu;
        private System.Windows.Forms.Label lbljouterfornisseur;
    }
}