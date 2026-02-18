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
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JECP9DF\\SQLZRV;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void BtnOyGirisi_Click(object sender, EventArgs e)
        {
            // oy girişi butonu ile veritabanına oy sayılarının eklenmesi

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtIlceAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtAParti.Text);
            komut.Parameters.AddWithValue("@p3", TxtBParti.Text);
            komut.Parameters.AddWithValue("@p4", TxtCParti.Text);
            komut.Parameters.AddWithValue("@p5", TxtDParti.Text);
            komut.Parameters.AddWithValue("@p6", TxtEParti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            // grafikler formuna geçiş yapılması
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void FrmOyGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
