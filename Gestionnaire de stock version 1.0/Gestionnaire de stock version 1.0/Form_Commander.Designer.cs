namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmCommander
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picmescommandes = new System.Windows.Forms.PictureBox();
            this.pic_returnemenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmescommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_returnemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.nouvellecommande;
            this.pictureBox1.Location = new System.Drawing.Point(44, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picmescommandes
            // 
            this.picmescommandes.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.Mescommandes;
            this.picmescommandes.Location = new System.Drawing.Point(44, 66);
            this.picmescommandes.Name = "picmescommandes";
            this.picmescommandes.Size = new System.Drawing.Size(300, 100);
            this.picmescommandes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picmescommandes.TabIndex = 1;
            this.picmescommandes.TabStop = false;
            this.picmescommandes.Click += new System.EventHandler(this.picmescommandes_Click);
            // 
            // pic_returnemenu
            // 
            this.pic_returnemenu.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.pic_returnemenu.Location = new System.Drawing.Point(13, 13);
            this.pic_returnemenu.Name = "pic_returnemenu";
            this.pic_returnemenu.Size = new System.Drawing.Size(31, 26);
            this.pic_returnemenu.TabIndex = 0;
            this.pic_returnemenu.TabStop = false;
            this.pic_returnemenu.Click += new System.EventHandler(this.pic_returnemenu_Click);
            // 
            // FrmCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picmescommandes);
            this.Controls.Add(this.pic_returnemenu);
            this.Name = "FrmCommander";
            this.Text = "Commander";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmescommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_returnemenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_returnemenu;
        private System.Windows.Forms.PictureBox picmescommandes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}