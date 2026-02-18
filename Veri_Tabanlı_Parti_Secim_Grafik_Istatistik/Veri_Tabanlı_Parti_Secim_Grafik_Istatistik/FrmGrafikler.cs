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

namespace Veri_Tabanlı_Parti_Secim_Grafik_Istatistik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

       // SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JECP9DF\SQLZRV;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private System.Windows.Forms.DataVisualization.Charting.Chart GetChart1()
        {
            return chart1;
        }

        //private void FrmGrafikler_Load(object sender, EventArgs e, System.Windows.Forms.DataVisualization.Charting.Chart chart1)
        //{
        //    // ilçe isimlerinin comboboxa yüklenmesi

        //    baglanti.Open();
        //    SqlCommand komut = new SqlCommand("select ILCEAD from TBLILCE", baglanti);
        //    SqlDataReader dr = komut.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        CmbIlce.Items.Add(dr[0]);
        //    }
        //    baglanti.Close();

        //    // grafiklere toplam oy sayılarının yüklenmesi

        //    baglanti.Open();
        //    SqlCommand komut2 = new SqlCommand("select sum(APARTI),sum(BPARTI),sum(CPARTI),sum(DPARTI),sum(EPARTI) from TBLILCE", baglanti);
        //    SqlDataReader dr2 = komut2.ExecuteReader();
        //    while (dr2.Read())
        //    {
        //        chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
        //        chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
        //        chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
        //        chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
        //        chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);
        //    }
        //    baglanti.Close();

        //}

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JECP9DF\SQLZRV;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // ilçe isimlerinin comboboxa yüklenmesi

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Items.Add(dr[0]);
            }
            baglanti.Close();

            // grafiklere toplam oy sayılarının yüklenmesi

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(APARTI),sum(BPARTI),sum(CPARTI),sum(DPARTI),sum(EPARTI) from TBLILCE", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);
            }
            baglanti.Close();
        }

        private void CmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboboxda seçilen ilçeye göre progressbara veri yüklenmesi ve labela yazdırılması

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLILCE where ILCEAD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbIlce.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                PrgA.Value = int.Parse(dr[2].ToString());
                PrgB.Value = int.Parse(dr[3].ToString());
                PrgC.Value = int.Parse(dr[4].ToString());
                PrgD.Value = int.Parse(dr[5].ToString());
                PrgE.Value = int.Parse(dr[6].ToString());
            }
            baglanti.Close();

            // labela oy sayılarını yazdırma
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLILCE where ILCEAD=@p2", baglanti);
            komut2.Parameters.AddWithValue("@p2", CmbIlce.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblA.Text = dr2[2].ToString();
                LblB.Text = dr2[3].ToString();
                LblC.Text = dr2[4].ToString();
                LblD.Text = dr2[5].ToString();
                LblE.Text = dr2[6].ToString();
            }
            baglanti.Close();
        }
    }
}
