using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletiUygulaması
{
    public partial class FrmFilmEkle : Form
    {
        public FrmFilmEkle()
        {
            InitializeComponent();
        }
        BaglanClass bgl = new BaglanClass();
        //public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=sinemabiletiotomasyonu;Uid=root;Pwd='12345678';");
        //MySqlConnection baglanti = new MySqlConnection(BaglanClass.MySqlConnection);
        sinemabiletiTableAdapters.film_bilgileriTableAdapter film = new sinemabiletiTableAdapters.film_bilgileriTableAdapter();


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmFilmEkle_Load(object sender, EventArgs e)
        {

        }

        private void FrmFilmEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAnasayfa anasayfa = new FrmAnasayfa();
            anasayfa.ShowDialog();
        }

        private void BtnFilmEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
            Random RND = new Random();
     
            string CommandText = "INSERT INTO film_bilgileri VALUES(@FilmId,@FilmAdi, @Yönetmen,@FilmTürü, @FilmSüresi,@YapimYili,@Tarih,@Resim)";
            MySqlCommand cmd = new MySqlCommand(CommandText, baglanti);

            cmd.Parameters.AddWithValue("@FilmId", RND.Next(1, 100));
            cmd.Parameters.AddWithValue("@FilmAdi", TxtFilmAdi.Text);
            cmd.Parameters.AddWithValue("@Yönetmen", TxtYönetmen.Text);
            cmd.Parameters.AddWithValue("@FilmTürü", comboBoxFilmTürü.Text);
            cmd.Parameters.AddWithValue("@FilmSüresi", TxtSüre.Text);
            cmd.Parameters.AddWithValue("@YapimYili", dateTimePickerYapımYılı.Text);
            cmd.Parameters.AddWithValue("@Tarih", dateTimePickerTarih.Text);
            cmd.Parameters.AddWithValue("@Resim", /*string.Empty*/pictureBox1.Location);

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
        }

        private void BtnAfis_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;

            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            openFileDialog1.ShowDialog();
            //pictureBox1SizeMod = pictureBox1.StretchImage;

            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
