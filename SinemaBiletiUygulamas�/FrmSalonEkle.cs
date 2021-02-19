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
    public partial class FrmSalonEkle : Form
    {
        public FrmSalonEkle()
        {
            InitializeComponent();
        }
        BaglanClass bgl = new BaglanClass();
        //public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=sinemabiletiotomasyonu;Uid=root;Pwd='12345678';");
        //MySqlConnection baglanti = new MySqlConnection(BaglanClass.MySqlConnection);
        sinemabiletiTableAdapters.salon_bilgileriTableAdapter salon = new sinemabiletiTableAdapters.salon_bilgileriTableAdapter();
        private void FrmSalonEkle_Load(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
            /*string insertQuery = "INSERT INTO salon_bilgileri(Salonadi) VALUES ('" + txtSalonAdi.Text + "')";

            MySqlCommand command = new MySqlCommand(insertQuery, baglanti);
            */
            Random RND = new Random();


            string CommandText = "INSERT INTO salon_bilgileri VALUES(@SalonId,@SalonAdi)";
            MySqlCommand cmd = new MySqlCommand(CommandText, baglanti);
            cmd.Parameters.AddWithValue("@SalonId", RND.Next(1, 100));
            cmd.Parameters.AddWithValue("@SalonAdi", SalonAdi.Text);

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
            SalonAdi.Text = " ";
        
    }

        private void FrmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        { 
            FrmAnasayfa anasayfa = new FrmAnasayfa();
            anasayfa.ShowDialog();
        }
    }
}
