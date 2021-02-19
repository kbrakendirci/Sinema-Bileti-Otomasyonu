using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace SinemaBiletiUygulaması
{
    public partial class FrmAnasayfa : Form
    {

        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        BaglanClass bgl = new BaglanClass();
        //public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=sinemabiletiotomasyonu;Uid=root;Pwd='12345678';");
        // public MySqlConnection baglanti = new MySqlConnection(BaglanClass.mySqlConnection);

        int sayac = 0;
        /* private void Anasayfa_Load(object sender, EventArgs e)
         {

         }
        */
        private void BtnFilmEkle_Click(object sender, EventArgs e)
        {
            FrmFilmEkle ekle = new FrmFilmEkle();
            ekle.Show();
            this.Hide();
        }

        private void BtnSalonEkle_Click(object sender, EventArgs e)
        {
            FrmSalonEkle ekle = new FrmSalonEkle();
            ekle.Show();
            this.Hide();
        }

        private void BtnSatısListeleme_Click(object sender, EventArgs e)
        {
            FrmSatisListele ekle = new FrmSatisListele();
            ekle.Show();
            this.Hide();
        }

        private void BtnSeansEkle_Click(object sender, EventArgs e)
        {
            FrmSeansEkle ekle = new FrmSeansEkle();
            ekle.Show();
            this.Hide();
        }

        private void BtnSeansListeleme_Click(object sender, EventArgs e)
        {
            FrmSeansListele ekle = new FrmSeansListele();
            ekle.Show();
            this.Hide();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {

        }

        private void comboboxDoldur(ComboBox combo, string sql1, string sql2)
        {
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sql1, baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();


        }

      
        
        private void Bos_Koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point((j * 30) + 50, i * 30 + 50);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    else if (j == 5)
                    {
                        continue;
                    }
                    sayac++;

                    panel1.Controls.Add(btn);//this butonların sıralı eklenmesini engelliyor.
                    btn.Click += Btn_Click;


                }
            }
        }
        
            private void filmSeansiGetir()
            {
                comboBoxFilmSeansı.Text = string.Empty;
                comboBoxFilmSeansı.Items.Clear();
                comboBoxFilmSeansiSaat.Text = string.Empty;
                comboBoxFilmSeansiSaat.Items.Clear();
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select * from seans_bilgileri where FilmAdi ='" + comboBoxFilmAdi.SelectedItem + "'AND SalonAdi='" + comboBoxSalonAdi.SelectedItem + "' ", baglanti);
                MySqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBoxFilmSeansı.Items.Add(read["Tarih"].ToString());

                    comboBoxFilmSeansiSaat.Items.Add(read["Seans"].ToString());
                }
                baglanti.Close();
            }

            private void filmTuruGetir()
            {
                comboBoxFilmTuru.Text = string.Empty;
                comboBoxFilmSeansı.Text = string.Empty;
                comboBoxFilmTuru.Items.Clear();
                comboBoxFilmSeansı.Items.Clear();
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select FilmTürü from film_bilgileri where FilmAdi ='" + comboBoxFilmAdi.SelectedItem + "' group by UPPER(FilmTürü) ", baglanti);
                MySqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBoxFilmTuru.Items.Add(read["FilmTürü"].ToString());
                }
                baglanti.Close();
            }



            private void FrmAnasayfa_Load(object sender, EventArgs e)
            {
                Bos_Koltuklar();//   // Kunlanıcı istediği Koltuğu ekranda seçinçe Bilet Satış Alanına ekleniyor
                comboboxDoldur(comboBoxFilmAdi, "select * from film_bilgileri", "FilmAdi");
                comboboxDoldur(comboBoxSalonAdi, "select * from salon_bilgileri", "SalonAdi");


            }
            public void FilmAfişiGoster()
            {
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select * from film_bilgileri where FilmAdi = '" + comboBoxFilmAdi.SelectedItem + "' ", baglanti);
                MySqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    pictureBox1.ImageLocation = read["Resim"].ToString();
                }
                baglanti.Close();
            }


            // Kunlanıcı istediği Koltuğu ekranda seçinçe Bilet Satış Alanına ekleniyor
            private void Btn_Click(object sender, EventArgs e)
            {
                Button b = (Button)sender;
                if (b.BackColor == Color.White)
                {
                    TxtKoltukNo.Text = b.Text;

                }

            }

            private void comboBoxFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
            {
                FilmAfişiGoster();
                filmTuruGetir();


            }
            sinemabiletiTableAdapters.satis_bilgileriTableAdapter satis = new sinemabiletiTableAdapters.satis_bilgileriTableAdapter();




            private void comboDoluKoltuk_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void BtnİptalEt_Click(object sender, EventArgs e)
            {

            }

            private void BtnBiletSatıs_Click(object sender, EventArgs e)
            {
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();

                string CommandText = "INSERT INTO satis_bilgileri VALUES( @SatisId, @KoltukNo,@SalonAdi,@FilmAdi,@Tarih,@Saat,@Ad,@Soyad,@Ucret,@Tarih2 )";
                MySqlCommand cmd = new MySqlCommand(CommandText, baglanti);
                Random RND = new Random();
                cmd.Parameters.AddWithValue("@SatisId", RND.Next(1, 100));
                cmd.Parameters.AddWithValue("@KoltukNo", TxtKoltukNo.Text);
                cmd.Parameters.AddWithValue("@FilmAdi", comboBoxFilmAdi.Text);
                cmd.Parameters.AddWithValue("@SalonAdi", comboBoxSalonAdi.Text);
                cmd.Parameters.AddWithValue("@Tarih", comboBoxFilmTuru.Text);
                cmd.Parameters.AddWithValue("@Saat", comboBoxFilmSeansı.Text);
                cmd.Parameters.AddWithValue("@Ad", TxtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
                cmd.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                cmd.Parameters.AddWithValue("@Tarih2", DateTime.Now.ToString());



                if (TxtKoltukNo.Text != " ")
                {
                    try
                    {
                        MessageBox.Show("Data Inserted");
                    }

                    catch (Exception hata)
                    {
                        MessageBox.Show("hata oluştur" + hata.Message, "uyarı");

                    }
                    
                }
                else
                {
                    MessageBox.Show("Koltuk Seçimi yapmadınız");
                }

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            baglanti.Close();
            TxtAd.Text = " ";
            TxtKoltukNo.Text = "";
            TxtSoyad.Text = "";
            TxtUcret.Text = "";
            comboBoxFilmAdi.Text = "";
            comboBoxFilmSeansiSaat.Text = "";
            comboBoxFilmSeansı.Text = "";
            comboBoxFilmTuru.Text = "";
            comboBoxSalonAdi.Text = "";


        }

            private void comboBoxSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
            {
                filmTuruGetir();
            }

            private void comboBoxFilmTuru_SelectedIndexChanged(object sender, EventArgs e)
            {
                filmSeansiGetir();

            }

            private void TxtKoltukNo_TextChanged(object sender, EventArgs e)
            {

            }

            private void comboBoxFilmSeansiSaat_SelectedIndexChanged(object sender, EventArgs e)
            {


            }

        private void TxtSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
