
namespace SinemaBiletiUygulaması
{
    partial class FrmSalonEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalonEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.SalonAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(256, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon Adı:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnEkle.Location = new System.Drawing.Point(355, 225);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(135, 23);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Salon Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // SalonAdi
            // 
            this.SalonAdi.Location = new System.Drawing.Point(355, 181);
            this.SalonAdi.Name = "SalonAdi";
            this.SalonAdi.Size = new System.Drawing.Size(135, 20);
            this.SalonAdi.TabIndex = 3;
            // 
            // FrmSalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.SalonAdi);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.label1);
            this.Name = "FrmSalonEkle";
            this.Text = "FrmSalonEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSalonEkle_FormClosing);
            this.Load += new System.EventHandler(this.FrmSalonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox SalonAdi;
    }
}