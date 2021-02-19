
namespace SinemaBiletiUygulaması
{
    partial class FrmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.BtnFilmEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSalonEkle = new System.Windows.Forms.Button();
            this.ımageList5 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSatısListeleme = new System.Windows.Forms.Button();
            this.ımageList4 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSeansEkle = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSeansListeleme = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.comboBoxFilmSeansiSaat = new System.Windows.Forms.ComboBox();
            this.BtnBiletSatıs = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtKoltukNo = new System.Windows.Forms.TextBox();
            this.comboBoxFilmSeansı = new System.Windows.Forms.ComboBox();
            this.comboBoxFilmTuru = new System.Windows.Forms.ComboBox();
            this.comboBoxSalonAdi = new System.Windows.Forms.ComboBox();
            this.comboBoxFilmAdi = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFilmEkle
            // 
            this.BtnFilmEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnFilmEkle.BackgroundImage = global::SinemaBiletiUygulaması.Properties.Resources.video_camera_neon_sign_1262_16217;
            this.BtnFilmEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFilmEkle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnFilmEkle.ImageIndex = 0;
            this.BtnFilmEkle.ImageList = this.ımageList1;
            this.BtnFilmEkle.Location = new System.Drawing.Point(237, 478);
            this.BtnFilmEkle.Name = "BtnFilmEkle";
            this.BtnFilmEkle.Size = new System.Drawing.Size(90, 61);
            this.BtnFilmEkle.TabIndex = 0;
            this.BtnFilmEkle.Text = "Film Ekle";
            this.BtnFilmEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFilmEkle.UseVisualStyleBackColor = false;
            this.BtnFilmEkle.Click += new System.EventHandler(this.BtnFilmEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "video-camera-neon-sign_1262-16217.jpg");
            this.ımageList1.Images.SetKeyName(1, "texte-style-enseignes-au-neon-billet-cinema_118419-2179.jpg");
            // 
            // BtnSalonEkle
            // 
            this.BtnSalonEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSalonEkle.BackgroundImage = global::SinemaBiletiUygulaması.Properties.Resources.cinema_hall_neon_sign_cinema_hall_neon_sign_vector_illustration_film_promotion_133482877;
            this.BtnSalonEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalonEkle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSalonEkle.ImageKey = "cinema-hall-neon-sign-cinema-hall-neon-sign-vector-illustration-film-promotion-13" +
    "3482877.jpg";
            this.BtnSalonEkle.Location = new System.Drawing.Point(32, 480);
            this.BtnSalonEkle.Name = "BtnSalonEkle";
            this.BtnSalonEkle.Size = new System.Drawing.Size(90, 60);
            this.BtnSalonEkle.TabIndex = 1;
            this.BtnSalonEkle.Text = "Salon Ekle";
            this.BtnSalonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalonEkle.UseVisualStyleBackColor = false;
            this.BtnSalonEkle.Click += new System.EventHandler(this.BtnSalonEkle_Click);
            // 
            // ımageList5
            // 
            this.ımageList5.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList5.ImageStream")));
            this.ımageList5.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList5.Images.SetKeyName(0, "cinema-hall-neon-sign-cinema-hall-neon-sign-vector-illustration-film-promotion-13" +
        "3482877.jpg");
            // 
            // BtnSatısListeleme
            // 
            this.BtnSatısListeleme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSatısListeleme.BackgroundImage = global::SinemaBiletiUygulaması.Properties.Resources.texte_style_enseignes_au_neon_billet_cinema_118419_2179;
            this.BtnSatısListeleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSatısListeleme.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSatısListeleme.ImageKey = "texte-style-enseignes-au-neon-billet-cinema_118419-2179.jpg";
            this.BtnSatısListeleme.Location = new System.Drawing.Point(837, 481);
            this.BtnSatısListeleme.Name = "BtnSatısListeleme";
            this.BtnSatısListeleme.Size = new System.Drawing.Size(90, 60);
            this.BtnSatısListeleme.TabIndex = 2;
            this.BtnSatısListeleme.Text = "Satıs Listeleme";
            this.BtnSatısListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSatısListeleme.UseVisualStyleBackColor = false;
            this.BtnSatısListeleme.Click += new System.EventHandler(this.BtnSatısListeleme_Click);
            // 
            // ımageList4
            // 
            this.ımageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList4.ImageStream")));
            this.ımageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList4.Images.SetKeyName(0, "texte-style-enseignes-au-neon-billet-cinema_118419-2179.jpg");
            // 
            // BtnSeansEkle
            // 
            this.BtnSeansEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSeansEkle.BackgroundImage = global::SinemaBiletiUygulaması.Properties.Resources.opened_clapper_neon_sign_1262_15682;
            this.BtnSeansEkle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSeansEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSeansEkle.ImageKey = "opened-clapper-neon-sign_1262-15682.jpg";
            this.BtnSeansEkle.ImageList = this.ımageList3;
            this.BtnSeansEkle.Location = new System.Drawing.Point(422, 484);
            this.BtnSeansEkle.Name = "BtnSeansEkle";
            this.BtnSeansEkle.Size = new System.Drawing.Size(90, 60);
            this.BtnSeansEkle.TabIndex = 3;
            this.BtnSeansEkle.Text = "Seans Ekle";
            this.BtnSeansEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSeansEkle.UseVisualStyleBackColor = false;
            this.BtnSeansEkle.Click += new System.EventHandler(this.BtnSeansEkle_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "opened-clapper-neon-sign_1262-15682.jpg");
            // 
            // BtnSeansListeleme
            // 
            this.BtnSeansListeleme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSeansListeleme.BackgroundImage = global::SinemaBiletiUygulaması.Properties.Resources.texte_style_enseignes_au_neon_heure_du_film_118419_2191;
            this.BtnSeansListeleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeansListeleme.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSeansListeleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSeansListeleme.ImageKey = "film-reel-neon-sign-vector-23044719.jpg";
            this.BtnSeansListeleme.ImageList = this.ımageList2;
            this.BtnSeansListeleme.Location = new System.Drawing.Point(623, 481);
            this.BtnSeansListeleme.Name = "BtnSeansListeleme";
            this.BtnSeansListeleme.Size = new System.Drawing.Size(90, 58);
            this.BtnSeansListeleme.TabIndex = 4;
            this.BtnSeansListeleme.Text = "Seans Listeleme";
            this.BtnSeansListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSeansListeleme.UseVisualStyleBackColor = false;
            this.BtnSeansListeleme.Click += new System.EventHandler(this.BtnSeansListeleme_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "film-reel-neon-sign-vector-23044719.jpg");
            this.ımageList2.Images.SetKeyName(1, "film-reel-neon-sign-vector-23044719.jpg");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(623, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 349);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.comboBoxFilmSeansiSaat);
            this.groupBox1.Controls.Add(this.BtnBiletSatıs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.TxtKoltukNo);
            this.groupBox1.Controls.Add(this.comboBoxFilmSeansı);
            this.groupBox1.Controls.Add(this.comboBoxFilmTuru);
            this.groupBox1.Controls.Add(this.comboBoxSalonAdi);
            this.groupBox1.Controls.Add(this.comboBoxFilmAdi);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 424);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Satış Bilgileri";
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtUcret.Location = new System.Drawing.Point(89, 309);
            this.TxtUcret.MaxLength = 1;
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(130, 20);
            this.TxtUcret.TabIndex = 17;
            // 
            // comboBoxFilmSeansiSaat
            // 
            this.comboBoxFilmSeansiSaat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxFilmSeansiSaat.FormattingEnabled = true;
            this.comboBoxFilmSeansiSaat.Location = new System.Drawing.Point(225, 135);
            this.comboBoxFilmSeansiSaat.Name = "comboBoxFilmSeansiSaat";
            this.comboBoxFilmSeansiSaat.Size = new System.Drawing.Size(72, 21);
            this.comboBoxFilmSeansiSaat.TabIndex = 11;
            this.comboBoxFilmSeansiSaat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmSeansiSaat_SelectedIndexChanged);
            // 
            // BtnBiletSatıs
            // 
            this.BtnBiletSatıs.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnBiletSatıs.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnBiletSatıs.Location = new System.Drawing.Point(89, 358);
            this.BtnBiletSatıs.Name = "BtnBiletSatıs";
            this.BtnBiletSatıs.Size = new System.Drawing.Size(130, 28);
            this.BtnBiletSatıs.TabIndex = 16;
            this.BtnBiletSatıs.Text = "Satış";
            this.BtnBiletSatıs.UseVisualStyleBackColor = false;
            this.BtnBiletSatıs.Click += new System.EventHandler(this.BtnBiletSatıs_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(17, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ücret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(20, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(20, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(17, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Koltuk No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Film Seansı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Film Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SalonAdı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FilmAdı";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtSoyad.Location = new System.Drawing.Point(89, 258);
            this.TxtSoyad.MaxLength = 30;
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(130, 20);
            this.TxtSoyad.TabIndex = 7;
            this.TxtSoyad.TextChanged += new System.EventHandler(this.TxtSoyad_TextChanged);
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtAd.Location = new System.Drawing.Point(89, 219);
            this.TxtAd.MaxLength = 30;
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(130, 20);
            this.TxtAd.TabIndex = 6;
            // 
            // TxtKoltukNo
            // 
            this.TxtKoltukNo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtKoltukNo.Enabled = false;
            this.TxtKoltukNo.Location = new System.Drawing.Point(89, 174);
            this.TxtKoltukNo.MaxLength = 1;
            this.TxtKoltukNo.Name = "TxtKoltukNo";
            this.TxtKoltukNo.Size = new System.Drawing.Size(130, 20);
            this.TxtKoltukNo.TabIndex = 5;
            this.TxtKoltukNo.TextChanged += new System.EventHandler(this.TxtKoltukNo_TextChanged);
            // 
            // comboBoxFilmSeansı
            // 
            this.comboBoxFilmSeansı.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxFilmSeansı.FormattingEnabled = true;
            this.comboBoxFilmSeansı.Location = new System.Drawing.Point(89, 135);
            this.comboBoxFilmSeansı.MaxLength = 1;
            this.comboBoxFilmSeansı.Name = "comboBoxFilmSeansı";
            this.comboBoxFilmSeansı.Size = new System.Drawing.Size(130, 21);
            this.comboBoxFilmSeansı.TabIndex = 3;
            // 
            // comboBoxFilmTuru
            // 
            this.comboBoxFilmTuru.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxFilmTuru.FormattingEnabled = true;
            this.comboBoxFilmTuru.Location = new System.Drawing.Point(89, 99);
            this.comboBoxFilmTuru.MaxLength = 1;
            this.comboBoxFilmTuru.Name = "comboBoxFilmTuru";
            this.comboBoxFilmTuru.Size = new System.Drawing.Size(130, 21);
            this.comboBoxFilmTuru.TabIndex = 2;
            this.comboBoxFilmTuru.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmTuru_SelectedIndexChanged);
            // 
            // comboBoxSalonAdi
            // 
            this.comboBoxSalonAdi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxSalonAdi.FormattingEnabled = true;
            this.comboBoxSalonAdi.Location = new System.Drawing.Point(89, 59);
            this.comboBoxSalonAdi.MaxLength = 1;
            this.comboBoxSalonAdi.Name = "comboBoxSalonAdi";
            this.comboBoxSalonAdi.Size = new System.Drawing.Size(130, 21);
            this.comboBoxSalonAdi.TabIndex = 1;
            this.comboBoxSalonAdi.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalonAdi_SelectedIndexChanged);
            // 
            // comboBoxFilmAdi
            // 
            this.comboBoxFilmAdi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxFilmAdi.FormattingEnabled = true;
            this.comboBoxFilmAdi.Location = new System.Drawing.Point(89, 22);
            this.comboBoxFilmAdi.MaxLength = 1;
            this.comboBoxFilmAdi.Name = "comboBoxFilmAdi";
            this.comboBoxFilmAdi.Size = new System.Drawing.Size(130, 21);
            this.comboBoxFilmAdi.TabIndex = 0;
            this.comboBoxFilmAdi.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmAdi_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(356, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 4);
            this.listBox1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(703, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(808, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "PERDE";
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaBiletiUygulaması.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 544);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSeansListeleme);
            this.Controls.Add(this.BtnSeansEkle);
            this.Controls.Add(this.BtnSatısListeleme);
            this.Controls.Add(this.BtnSalonEkle);
            this.Controls.Add(this.BtnFilmEkle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FrmAnasayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFilmEkle;
        private System.Windows.Forms.Button BtnSalonEkle;
        private System.Windows.Forms.Button BtnSatısListeleme;
        private System.Windows.Forms.Button BtnSeansEkle;
        private System.Windows.Forms.Button BtnSeansListeleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtKoltukNo;
        private System.Windows.Forms.ComboBox comboBoxFilmSeansı;
        private System.Windows.Forms.ComboBox comboBoxFilmTuru;
        private System.Windows.Forms.ComboBox comboBoxSalonAdi;
        private System.Windows.Forms.ComboBox comboBoxFilmAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBiletSatıs;
        private System.Windows.Forms.ComboBox comboBoxFilmSeansiSaat;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList5;
        private System.Windows.Forms.ImageList ımageList4;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
    }
}

