using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

 

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
  
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (soruno == 1)
                    {
                        if (textBox1.Text == "Akdeniz" || textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 2)
                    {
                        if (textBox1.Text == "Bursa" || textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 3)
                    {
                        if (textBox1.Text == "Cuma" || textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 4)
                    {
                        if (textBox1.Text == "Diyarbakır" || textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 5)
                    {
                        if (textBox1.Text == "Eski" || textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 6)
                    {
                        if (textBox1.Text == "Ferman" || textBox1.Text == "ferman")
                        {
                            BtnF.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnF.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 7)
                    {
                        if (textBox1.Text == "Güneş" || textBox1.Text == "güneş")
                        {
                            BtnG.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnG.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 8)
                    {
                        if (textBox1.Text == "Halı" || textBox1.Text == "halı")
                        {
                            BtnH.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnH.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 9)
                    {
                        if (textBox1.Text == "Isparta" || textBox1.Text == "ısparta")
                        {
                            BtnI.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnI.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 10)
                    {
                        if (textBox1.Text == "İçel" || textBox1.Text == "içel")
                        {
                            BtnI2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnI2.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 11)
                    {
                        if (textBox1.Text == "Jandarma" || textBox1.Text == "jandarma")
                        {
                            BtnJ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnJ.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 12)
                    {
                        if (textBox1.Text == "Kayısı" || textBox1.Text == "kayısı")
                        {
                            BtnK.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnK.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 13)
                    {
                        if (textBox1.Text == "Lale" || textBox1.Text == "lale")
                        {
                            BtnL.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnL.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 14)
                    {
                        if (textBox1.Text == "Mart" || textBox1.Text == "mart")
                        {
                            BtnM.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnM.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 15)
                    {
                        if (textBox1.Text == "Ney" || textBox1.Text == "ney")
                        {
                            BtnN.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnN.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 16)
                    {
                        if (textBox1.Text == "Ozan" || textBox1.Text == "ozan")
                        {
                            BtnO.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnO.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 17)
                    {
                        if (textBox1.Text == "Pırasa" || textBox1.Text == "pırasa")
                        {
                            BtnP.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnP.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 18)
                    {
                        if (textBox1.Text == "Ramazan" || textBox1.Text == "ramazan")
                        {
                            BtnR.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnR.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 19)
                    {
                        if (textBox1.Text == "Snake" || textBox1.Text == "snake")
                        {
                            BtnS.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnS.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 20)
                    {
                        if (textBox1.Text == "Tarkan" || textBox1.Text == "tarkan")
                        {
                            BtnT.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnT.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 21)
                    {
                        if (textBox1.Text == "Umut" || textBox1.Text == "umut")
                        {
                            BtnU.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnU.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 22)
                    {
                        if (textBox1.Text == "Van" || textBox1.Text == "van")
                        {
                            BtnV.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnV.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 23)
                    {
                        if (textBox1.Text == "Yıldırım" || textBox1.Text == "yıldırım")
                        {
                            BtnY.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnY.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }
                    if (soruno == 24)
                    {
                        if (textBox1.Text == "Zeytin" || textBox1.Text == "zeytin")
                        {
                            BtnZ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnZ.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                    }

                    textBox1.Clear();
                    break;

                case Keys.Escape:
                    this.Close();
                
                    break;

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            // 24 soru için gerekli kodlar

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi hangisidir?";
                button1.BackColor = Color.Yellow;
                button25.Text=button1.Text;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmara ilimiz?";
                button2.BackColor = Color.Yellow;
                button25.Text = button2.Text;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
                button25.Text = button3.Text;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
                button25.Text = button4.Text;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow;
                button25.Text = button5.Text;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                BtnF.BackColor = Color.Yellow;
                button25.Text = BtnF.Text;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                BtnG.BackColor = Color.Yellow;
                button25.Text = BtnG.Text;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                BtnH.BackColor = Color.Yellow;
                button25.Text = BtnH.Text;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                BtnI.BackColor = Color.Yellow;
                button25.Text = BtnI.Text;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer adı?";
                BtnI2.BackColor = Color.Yellow;
                button25.Text = BtnI2.Text;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                BtnJ.BackColor = Color.Yellow;
                button25.Text = BtnJ.Text;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                BtnK.BackColor = Color.Yellow;
                button25.Text = BtnK.Text;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                BtnL.BackColor = Color.Yellow;
                button25.Text = BtnL.Text;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                BtnM.BackColor = Color.Yellow;
                button25.Text = BtnM.Text;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                BtnN.BackColor = Color.Yellow;
                button25.Text = BtnN.Text;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                BtnO.BackColor = Color.Yellow;
                button25.Text = BtnO.Text;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzelerle yapılan yemek?";
                BtnP.BackColor = Color.Yellow;
                button25.Text = BtnP.Text;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                BtnR.BackColor = Color.Yellow;
                button25.Text = BtnR.Text;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                BtnS.BackColor = Color.Yellow;
                button25.Text = BtnS.Text;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı?";
                BtnT.BackColor = Color.Yellow;
                button25.Text = BtnT.Text;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                BtnU.BackColor = Color.Yellow;
                button25.Text = BtnU.Text;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                BtnV.BackColor = Color.Yellow;
                button25.Text = BtnV.Text;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                BtnY.BackColor = Color.Yellow;
                button25.Text = BtnY.Text;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
                BtnZ.BackColor = Color.Yellow;
                button25.Text = BtnZ.Text;
            }

            if(soruno>24)
            {
                MessageBox.Show("Oyun Bitti! Doğru cevap sayınız: " + dogru.ToString() + "\n" + "Yanlış cevap sayınız: " + yanlis.ToString());
                button25.Text = "";
            }
        }

    }
}
