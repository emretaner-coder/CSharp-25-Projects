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

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JECP9DF\SQLZRV;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet1.TBLDERS' table. You can move, or remove it, as needed.
            // this.tBLDERSTableAdapter1.Fill(this.dbNotKayitDataSet1.TBLDERS);
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet2.TBLDERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // öğrenci kaydetme

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA, OGRAD, OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", MskNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //datagridview yenileme
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet2.TBLDERS);
        }

        private TextBox GetTxtSinav2()
        {
            return TxtSinav2;
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e, TextBox txtSinav2)
        //{
        //    // datagridviewden textboxlara veri çekme

        //    int secilen = dataGridView1.SelectedCells[0].RowIndex;
        //    MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        //    TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        //    TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        //    TxtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        //    txtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        //    TxtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            // not güncelleme

            double ortalama, s1, s2, s3;
            string durum;

            s1 = Convert.ToDouble(TxtSinav1.Text);
            s2 = Convert.ToDouble(TxtSinav2.Text);
            s3 = Convert.ToDouble(TxtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            LblOrtalama.Text = ortalama.ToString("0.00");


            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@p1, OGRS2=@p2, OGRS3=@p3, ORTALAMA=@p4, DURUM=@p5 where OGRNUMARA=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtSinav1.Text);
            komut.Parameters.AddWithValue("@p2", TxtSinav2.Text);
            komut.Parameters.AddWithValue("@p3", TxtSinav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(LblOrtalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", MskNumara.Text);
            int v = komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);




            //datagridview yenileme
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet2.TBLDERS);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet2.TBLDERS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet2.TBLDERS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FrmOgretmenDetay_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet2.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet2.TBLDERS);

            // geçen kalan öğrenci sayısını labellara çekme

            SqlCommand komut2 = new SqlCommand("select count(*) from TBLDERS where DURUM='True'", baglanti);
            SqlCommand komut3 = new SqlCommand("select count(*) from TBLDERS where DURUM='False'", baglanti);
            baglanti.Open();
            int gecerli = Convert.ToInt32(komut2.ExecuteScalar());
            int gecersiz = Convert.ToInt32(komut3.ExecuteScalar());
            LblGecenSayisi.Text = gecerli.ToString();
            LblKalanSayisi.Text = gecersiz.ToString();
            baglanti.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // datagridviewden textboxlara veri çekme

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

    }
}
