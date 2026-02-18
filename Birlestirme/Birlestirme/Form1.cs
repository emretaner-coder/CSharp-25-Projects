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

namespace Birlestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JECP9DF\\SQLZRV;Initial Catalog=DbBirlestirme;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // verileri datagridview'e aktarma
            SqlDataAdapter da = new SqlDataAdapter("SELECT HAREKETID,URUNAD,(AD+' '+SOYAD) AS 'MÜŞTERİ',ADSOYAD AS 'PERSONEL',FIYAT FROM TBLHAREKET INNER JOIN TBLURUNLER ON TBLHAREKET.URUN=TBLURUNLER.URUNID INNER JOIN TBLMUSTERI ON TBLHAREKET.MUSTERI=TBLMUSTERI.ID INNER JOIN TBLPERSONEL ON TBLHAREKET.PERSONEL=TBLPERSONEL.ID", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
