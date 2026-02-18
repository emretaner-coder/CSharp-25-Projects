using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JECP9DF\\SQLZRV;Initial Catalog=FilmArsivim;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLFILMLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // filmleri kaydetme

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFILMLER (AD, KATEGORI, LINK) values (@p1, @p2, @p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKategori.Text);
            komut.Parameters.AddWithValue("@p3", TxtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();
            // temizleme
            TxtFilmAd.Clear();
            TxtKategori.Clear();
            TxtLink.Clear();
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // linkten filmi web browserda açma

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Emre TANER tarafından 30.01.2026 tarihinde C# ile geliştirilmiştir.", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRenkDegistir_Click(object sender, EventArgs e)
        {
            // butona tıklayınca arka plan rengini rastgele değiştir

            Random rnd = new Random();
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

        }

        private void BtnTamEkran_Click(object sender, EventArgs e)
        {
            // butona tıklayınca web browseri tam ekran yapma

            this.WindowState = FormWindowState.Maximized;
            groupBox1.Size = new Size(1920, 1000);
            groupBox1.Location = new Point(0, 0);
        }
    }
}
