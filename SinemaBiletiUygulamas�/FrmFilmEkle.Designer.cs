
namespace SinemaBiletiUygulaması
{
    partial class FrmFilmEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilmEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtFilmAdi = new System.Windows.Forms.TextBox();
            this.TxtYönetmen = new System.Windows.Forms.TextBox();
            this.TxtSüre = new System.Windows.Forms.TextBox();
            this.comboBoxFilmTürü = new System.Windows.Forms.ComboBox();
            this.dateTimePickerYapımYılı = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.BtnFilmEkle = new System.Windows.Forms.Button();
            this.BtnAfis = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(264, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(264, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(264, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FilmTürü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(264, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(264, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "YapımYılı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(264, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // TxtFilmAdi
            // 
            this.TxtFilmAdi.Location = new System.Drawing.Point(334, 134);
            this.TxtFilmAdi.Name = "TxtFilmAdi";
            this.TxtFilmAdi.Size = new System.Drawing.Size(200, 20);
            this.TxtFilmAdi.TabIndex = 7;
            // 
            // TxtYönetmen
            // 
            this.TxtYönetmen.Location = new System.Drawing.Point(334, 176);
            this.TxtYönetmen.Name = "TxtYönetmen";
            this.TxtYönetmen.Size = new System.Drawing.Size(200, 20);
            this.TxtYönetmen.TabIndex = 8;
            // 
            // TxtSüre
            // 
            this.TxtSüre.Location = new System.Drawing.Point(334, 271);
            this.TxtSüre.Name = "TxtSüre";
            this.TxtSüre.Size = new System.Drawing.Size(200, 20);
            this.TxtSüre.TabIndex = 9;
            // 
            // comboBoxFilmTürü
            // 
            this.comboBoxFilmTürü.FormattingEnabled = true;
            this.comboBoxFilmTürü.Location = new System.Drawing.Point(334, 221);
            this.comboBoxFilmTürü.Name = "comboBoxFilmTürü";
            this.comboBoxFilmTürü.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFilmTürü.TabIndex = 11;
            // 
            // dateTimePickerYapımYılı
            // 
            this.dateTimePickerYapımYılı.Location = new System.Drawing.Point(334, 324);
            this.dateTimePickerYapımYılı.Name = "dateTimePickerYapımYılı";
            this.dateTimePickerYapımYılı.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerYapımYılı.TabIndex = 12;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(334, 384);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTarih.TabIndex = 13;
            // 
            // BtnFilmEkle
            // 
            this.BtnFilmEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnFilmEkle.Location = new System.Drawing.Point(650, 197);
            this.BtnFilmEkle.Name = "BtnFilmEkle";
            this.BtnFilmEkle.Size = new System.Drawing.Size(89, 40);
            this.BtnFilmEkle.TabIndex = 14;
            this.BtnFilmEkle.Text = "Film Ekle";
            this.BtnFilmEkle.UseVisualStyleBackColor = false;
            this.BtnFilmEkle.Click += new System.EventHandler(this.BtnFilmEkle_Click);
            // 
            // BtnAfis
            // 
            this.BtnAfis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAfis.Location = new System.Drawing.Point(650, 287);
            this.BtnAfis.Name = "BtnAfis";
            this.BtnAfis.Size = new System.Drawing.Size(89, 39);
            this.BtnAfis.TabIndex = 15;
            this.BtnAfis.Text = "Afiş Seç";
            this.BtnAfis.UseVisualStyleBackColor = false;
            this.BtnAfis.Click += new System.EventHandler(this.BtnAfis_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(12, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 277);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAfis);
            this.Controls.Add(this.BtnFilmEkle);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.dateTimePickerYapımYılı);
            this.Controls.Add(this.comboBoxFilmTürü);
            this.Controls.Add(this.TxtSüre);
            this.Controls.Add(this.TxtYönetmen);
            this.Controls.Add(this.TxtFilmAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFilmEkle";
            this.Text = "FrmFilmEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFilmEkle_FormClosing);
            this.Load += new System.EventHandler(this.FrmFilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TxtFilmAdi;
        private System.Windows.Forms.TextBox TxtYönetmen;
        private System.Windows.Forms.TextBox TxtSüre;
        private System.Windows.Forms.ComboBox comboBoxFilmTürü;
        private System.Windows.Forms.DateTimePicker dateTimePickerYapımYılı;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.Button BtnFilmEkle;
        private System.Windows.Forms.Button BtnAfis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}