namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmStock
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
            this.lblstock = new System.Windows.Forms.Label();
            this.picretournemenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(327, 9);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(105, 39);
            this.lblstock.TabIndex = 0;
            this.lblstock.Text = "Stock";
            // 
            // picretournemenu
            // 
            this.picretournemenu.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picretournemenu.Location = new System.Drawing.Point(13, 9);
            this.picretournemenu.Name = "picretournemenu";
            this.picretournemenu.Size = new System.Drawing.Size(35, 27);
            this.picretournemenu.TabIndex = 1;
            this.picretournemenu.TabStop = false;
            this.picretournemenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picretournemenu);
            this.Controls.Add(this.lblstock);
            this.Name = "FrmStock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.PictureBox picretournemenu;
    }
}