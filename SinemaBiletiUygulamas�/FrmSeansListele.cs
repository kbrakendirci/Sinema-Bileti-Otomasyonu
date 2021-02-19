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
    public partial class FrmSeansListele : Form
    {
        public FrmSeansListele()
        {
            InitializeComponent();
        }
        BaglanClass bgl = new BaglanClass();
        sinemabiletiTableAdapters.seans_bilgileriTableAdapter FilmSeansı = new sinemabiletiTableAdapters.seans_bilgileriTableAdapter();
        //public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=sinemabiletiotomasyonu;Uid=root;Pwd='12345678';");
        // MySqlConnection baglanti = new MySqlConnection(BaglanClass.MySqlConnection);


        DataTable tablo = new DataTable();

        private void SeansListesi(string sql)
        {
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter(sql, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void FrmSeansListele_Load(object sender, EventArgs e)
        {
            SeansListesi("select * from seans_bilgileri where Tarih like '" + dateTimePicker1.Text + "'");
        }

        private void FrmSeansListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAnasayfa anasayfa = new FrmAnasayfa();
            anasayfa.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SeansListesi("select * from seans_bilgileri where Tarih like '" + dateTimePicker1.Text + "'");
        }
    
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select * from seans_bilgileri where Tarih like '" + dateTimePicker1.Text + "'");

        }

        private void BtnSeansListele_Click(object sender, EventArgs e)
        {

            tablo.Clear();
            SeansListesi("select * from seans_bilgileri ");
        }
    }
}
