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
    public partial class FrmSeansEkle : Form
    {
        public FrmSeansEkle()
        {
            InitializeComponent();
        }
        BaglanClass bgl = new BaglanClass();

        sinemabiletiTableAdapters.seans_bilgileriTableAdapter FilmSeansı = new sinemabiletiTableAdapters.seans_bilgileriTableAdapter();
        //public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=sinemabiletiotomasyonu;Uid=root;Pwd='12345678';");
        //MySqlConnection baglanti = new MySqlConnection(BaglanClass.MySqlConnection);

        private void FrmSeansEkle_Load(object sender, EventArgs e)
        {
            FilmveSalonGoster(comboBoxFilmAdi, "select *from film_bilgileri", "FilmAdi");
            FilmveSalonGoster(comboBoxSalonAdi, "select *from salon_bilgileri", "SalonAdi");
        }

        private void FrmSeansEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAnasayfa anasayfa = new FrmAnasayfa();
            anasayfa.ShowDialog();
        }
        string seans = " ";

        private void RadioButtonSeciliyse()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;

        }


        private void FilmveSalonGoster(ComboBox combo, string sql, string sql2)
        {
            //Diğer tablolardaki bilgileri çekiyor
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sql, baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();

            string CommandText = "INSERT INTO seans_bilgileri VALUES( @SeansId, @FilmAdi,@SalonAdi,@Tarih,@Seans )";
            MySqlCommand cmd = new MySqlCommand(CommandText, baglanti);
            Random RND = new Random();
            cmd.Parameters.AddWithValue("@SeansId", RND.Next(1, 100));
            cmd.Parameters.AddWithValue("@FilmAdi", comboBoxFilmAdi.Text);
            cmd.Parameters.AddWithValue("@SalonAdi", comboBoxSalonAdi.Text);
            cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Seans", seans);

            if (seans != "")
            {
                RadioButtonSeciliyse();
                // filmseansi.SeansEkleme(comboBoxfilmlistele.Text, comboBoxSalonListele.Text, dateTimePicker1.Text, seans);
                //  MessageBox.Show("Seans Ekleme işlemi başarılı");
                MessageBox.Show("Salon Eklendi");
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

            else if (seans == "")
            {
                MessageBox.Show("Seans seçimi yapmadınız");
            }
            comboBoxFilmAdi.Text = "";
            comboBoxSalonAdi.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void TarihiKarşılaştır()
        {
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select *from seans_bilgileri where SalonAdi='" + comboBoxSalonAdi.Text + "' and Tarih='" + dateTimePicker1.Text + "'", baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in panel1.Controls)
                {
                    if (read["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;

                    }

                }

            }
            baglanti.Close();
        }
        private void comboBoxSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            foreach (Control item3 in panel1.Controls)
            {
                item3.Enabled = true;
            }
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);//Seçilen Sinema Seansı
            if (yeni == bugün)//Seçilen Seans Şu anki Tarihe eşitse Saatler Karşılaştırılır.Bilet Alınamıcak Seansları pasif Hale getirir
            {
                foreach (Control item in panel1.Controls)
                {

                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                TarihiKarşılaştır();
            }
            else if (yeni > bugün)
            {
                TarihiKarşılaştır();
            }
            else if (yeni < bugün)
            {// Kunlanıcının önceki günlere Bilet alması engellenir.
                MessageBox.Show("Geriye dönük işlem yapılamaz!!!", "Uyarı");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();


            }


        }

        private void comboBoxFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
