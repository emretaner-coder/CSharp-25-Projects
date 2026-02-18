using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Kitaplik_Test
{
    internal class Kitap_Vt
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Emre TANER\\Desktop\\Kitaplik.mdb");
        public List<Kitap> Liste()
        {
            List<Kitap> ktp = new List<Kitap>();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt32(oku[0].ToString());
                k.Ad = oku[1].ToString();
                k.Yazar = oku[2].ToString();
                ktp.Add(k);
            }
            baglanti.Close();
            return ktp;
        }

        public void Ekle(Kitap kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert Into Kitaplar (KitapAd,Yazar) Values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", kt.Ad);
            komut.Parameters.AddWithValue("@p2", kt.Yazar);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
