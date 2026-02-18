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

namespace SQL_Derleyici_Ekrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JECP9DF\\SQLZRV;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            // richTextBox1'e yazılan SQL sorgusunu çalıştırma
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(richTextBox1.Text, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ekleme silme güncelleme işlemleri için
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(richTextBox1.Text, baglanti);
                int sonuc = komut.ExecuteNonQuery();
                MessageBox.Show(sonuc + " kayıt etkilendi.");
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
            // dataGridView'i güncelle
            button1.PerformClick();
        }

        string veritabaniSecmeSorgusu;
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // USE ile istediğimiz veritabanını seçme işlemi

            veritabaniSecmeSorgusu = richTextBox1.Text;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(veritabaniSecmeSorgusu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
            button1.PerformClick();
           
            // hangi veritabanını seçtiğimizi göstermek için formun başlığını güncelleme
            
            string[] sorguParcalari = veritabaniSecmeSorgusu.Split(' ');
            if (sorguParcalari.Length >= 2)
            {
                string secilenVeritabani = sorguParcalari[1];
                this.Text = "SQL Derleyici Ekranı - " + secilenVeritabani;
            }

        }
    }
}
