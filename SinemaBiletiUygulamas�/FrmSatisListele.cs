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
    public partial class FrmSatisListele : Form
    {
        public FrmSatisListele()
        {
            InitializeComponent();
        }
        BaglanClass bgl = new BaglanClass();
        sinemabiletiTableAdapters.satis_bilgileriTableAdapter FilmSeansı = new sinemabiletiTableAdapters.satis_bilgileriTableAdapter();
         //public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=sinemabiletiotomasyonu;Uid=root;Pwd='12345678';");
        //MySqlConnection baglanti = new MySqlConnection(BaglanClass.MySqlConnection);
        DataTable tablo = new DataTable();
        private void SatisListesi(string sql)
        {
            MySqlConnection baglanti = new MySqlConnection(bgl.Adres);
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter(sql, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            int ucrettoplami = 0;
            for (int i=0;i<dataGridView1.Rows.Count;i++)
            {
                int v = Convert.ToInt32(dataGridView1.Rows[i].Cells["Ucret"].Value);
                ucrettoplami += v;
            }
            label1.Text = "Toplam Satış=" + ucrettoplami + "TL";
            
            baglanti.Close();
         
            
        }

        private void FrmSatisListele_Load(object sender, EventArgs e)
        {
            SatisListesi("select * from satis_bilgileri where Tarih2 like '" + dateTimePicker1.Text + "'");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SatisListesi("select * from satis_bilgileri where Tarih2 like '" + dateTimePicker1.Text + "'");
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SatisListesi("select * from satis_bilgileri " );
        }

        private void FrmSatisListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAnasayfa anasayfa = new FrmAnasayfa();
            anasayfa.ShowDialog();
        }
    }
}



