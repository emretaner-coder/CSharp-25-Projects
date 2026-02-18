using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Satis_Projesi
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JECP9DF\\SQLZRV;Initial Catalog=DbSatis;Integrated Security=True");
        private void FrmSatis_Load(object sender, EventArgs e)
        {
            //ÜRÜNLERİ COMBOBOXA GETİRME

            SqlCommand komut = new SqlCommand("Select * From URUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrun.ValueMember="ID";
            CmbUrun.DisplayMember="AD";
            CmbUrun.DataSource = dt;

            //MÜŞTERİLERİ COMBOBOXA GETİRME

            SqlCommand komut2 = new SqlCommand("Select * From MUSTERILER", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbMusteri.ValueMember = "ID";
            CmbMusteri.DisplayMember = "ADSOYAD";
            CmbMusteri.DataSource = dt2;

            //PERSONELLERİ COMBOBOXA GETİRME

            SqlCommand komut3 = new SqlCommand("Select * From PERSONELLER", baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            CmbPersonel.ValueMember = "ID";
            CmbPersonel.DisplayMember = "AD";
            CmbPersonel.DataSource = dt3;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SATIŞ İŞLEMİ YAPMA

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into HAREKETLER (URUN,MUSTERI,PERSONEL,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", CmbMusteri.SelectedValue);
            komut.Parameters.AddWithValue("@p3", CmbPersonel.SelectedValue);
            komut.Parameters.AddWithValue("@p4", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış İşlemi Gerçekleşti","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnHareketler_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
