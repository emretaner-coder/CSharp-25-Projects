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

namespace Sifreli_Veriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JECP9DF\\SQLZRV;Initial Catalog=DBSIFRELEME;Integrated Security=True");

        void listele()
        {
            // dataset kavramı ile şifreli verileri çözerek listeleme

            SqlDataAdapter da = new SqlDataAdapter("select ID,AD,SOYAD,MAIL,SIFRE,HESAPNO from TBLVERILER", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                row["AD"] = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(row["AD"].ToString()));
                row["SOYAD"] = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(row["SOYAD"].ToString()));
                row["MAIL"] = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(row["MAIL"].ToString()));
                row["SIFRE"] = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(row["SIFRE"].ToString()));
                row["HESAPNO"] = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(row["HESAPNO"].ToString()));
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // verileri şifreleyerek kaydetme

            string ad = TxtAd.Text;
            byte[] addizi=ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string soyad = TxtSoyad.Text;
            byte[] soyaddizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string mail = TxtMail.Text;
            byte[] maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = TxtSifre.Text;
            byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string hesapno = TxtHesapNo.Text;
            byte[] hesapnodizi = ASCIIEncoding.ASCII.GetBytes(hesapno);
            string hesapnosifre = Convert.ToBase64String(hesapnodizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifresifre);
            komut.Parameters.AddWithValue("@p5", hesapnosifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ASCII çözme örneği

            string adcozum = TxtAd.Text;
            byte[] adcozumdizi = Convert.FromBase64String(adcozum);
            string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizi);

            string soyadcozum = TxtSoyad.Text;
            byte[] soyadcozumdizi = Convert.FromBase64String(soyadcozum);
            string soyadverisi = ASCIIEncoding.ASCII.GetString(soyadcozumdizi);

            string mailcozum = TxtMail.Text;
            byte[] mailcozumdizi = Convert.FromBase64String(mailcozum);
            string mailverisi = ASCIIEncoding.ASCII.GetString(mailcozumdizi);

            string sifrecozum = TxtSifre.Text;
            byte[] sifrecozumdizi = Convert.FromBase64String(sifrecozum);
            string sifreverisi = ASCIIEncoding.ASCII.GetString(sifrecozumdizi);

            string hesapnocozum = TxtHesapNo.Text;
            byte[] hesapnocozumdizi = Convert.FromBase64String(hesapnocozum);
            string hesapnoverisi = ASCIIEncoding.ASCII.GetString(hesapnocozumdizi);

            // verileri çözüp listeleme

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD,SOYAD,MAIL,SIFRE,HESAPNO from TBLVERILER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
    }
}
