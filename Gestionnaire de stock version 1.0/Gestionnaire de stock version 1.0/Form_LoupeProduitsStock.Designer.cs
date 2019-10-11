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
            this.cboProduits = new System.Windows.Forms.ListBox();
            this.cmdValidder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProduits
            // 
            this.cboProduits.FormattingEnabled = true;
            this.cboProduits.Location = new System.Drawing.Point(47, 69);
            this.cboProduits.Name = "cboProduits";
            this.cboProduits.Size = new System.Drawing.Size(186, 277);
            this.cboProduits.TabIndex = 0;
            // 
            // cmdValidder
            // 
            this.cmdValidder.Location = new System.Drawing.Point(47, 362);
            this.cmdValidder.Name = "cmdValidder";
            this.cmdValidder.Size = new System.Drawing.Size(186, 34);
            this.cmdValidder.TabIndex = 1;
            this.cmdValidder.Text = "Valider";
            this.cmdValidder.UseVisualStyleBackColor = true;
            this.cmdValidder.Click += new System.EventHandler(this.cmdValidder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLoupeProduitStcok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdValidder);
            this.Controls.Add(this.cboProduits);
            this.Name = "FrmLoupeProduitStcok";
            this.Text = "Form_LoupeProduitsStock";
            this.Load += new System.EventHandler(this.FrmLoupeProduitStcok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cboProduits;
        private System.Windows.Forms.Button cmdValidder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}