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

namespace Banka_Simulasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string hesap;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JECP9DF\SQLZRV;Initial Catalog=DbBanka;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            LblHesapNo.Text = hesap;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLKISILER WHERE HESAPNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                LblTcKimlik.Text = dr[3].ToString();
                LblTelefon.Text = dr[4].ToString();
            }
            baglanti.Close();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            // gönderilen hesabın para artışı

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TBLHESAP SET BAKIYE=BAKIYE+@p1 WHERE HESAPNO=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@p2", MskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();


            // gönderen hesabın para azalışı

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update tblhesap set bakıye=bakıye-@k1 where hesapno=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(TxtTutar.Text));
            komut2.Parameters.AddWithValue("@k2", hesap);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Gerçekleşti");

            // hareket tablosu
            //baglanti.Open();
            //SqlCommand komut3 = new SqlCommand("insert into tblhareket (gonderen,alıcı,tutar) values (@p1,@p2,@p3)", baglanti);
            //komut3.Parameters.AddWithValue("p1",LblAdSoyad.Text);
            //komut3.Parameters.AddWithValue("p2",)
        }
    }
}
