using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("Ahmet");
            karakterler.Add("Mehmet");
            karakterler.Add("Ayşe");
            karakterler.Add("Fatma");
            karakterler.Add("Ali");
            karakterler.Add("Veli");
            karakterler.Remove("Ali");

            foreach (string kisi in karakterler)
            {
                listBox1.Items.Add(kisi);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(74);
            sayilar.Add(25);
            sayilar.Add(33);
            sayilar.Add(22);
            sayilar.Add(15);
            sayilar.Add(14);
            sayilar.Add(80);
            foreach (int sayi in sayilar)
            {
                if (sayi % 5 == 0)
                {
                    listBox2.Items.Add(sayi);
                }

            }
            if (sayilar.Contains(25))
            {
                MessageBox.Show("25 sayısı listede mevcut.");
            }
            else
            {
                MessageBox.Show("25 sayısı listede mevcut değil.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();

            kisi.Add(new Kisiler()
            {
                Adı = "Ahmet",
                Soyadı = "Yılmaz",
                Mesleki = "Mühendis"
            });

            kisi.Add(new Kisiler()
            {
                Adı = "Mehmet",
                Soyadı = "Demir",
                Mesleki = "Doktor"
            });

            kisi.Add(new Kisiler()
            {
                Adı = "Ayşe",
                Soyadı = "Kara",
                Mesleki = "Öğretmen"
            });

            kisi.Add(new Kisiler()
            {
                Adı = "Fatma",
                Soyadı = "Çelik",
                Mesleki = "Avukat"
            });

            kisi.Add(new Kisiler()
            {
                Adı = "Ali",
                Soyadı = "Kaya",
                Mesleki = "Mimar"
            });

            foreach (Kisiler k in kisi)
            {
                listBox3.Items.Add(k.Adı + " " + k.Soyadı + " - " + k.Mesleki);
            }
        }
    }
}
