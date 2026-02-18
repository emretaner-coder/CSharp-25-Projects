using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Nesne_Hareketler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 12)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 700)
            {
                timer2.Stop();
                timer3.Start();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 507)
            {
                timer3.Stop();
                timer4.Start();
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 219)
            {
                timer4.Stop();
                timer5.Start();
            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 133)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 670)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 390)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 320)
            {
                timer8.Stop();
                timer9.Start();
            }
        }

        private void timer9_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 230)
            {
                timer9.Stop();
                timer10.Start();
            }
        }

        private void timer10_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 450)
            {
                timer10.Stop();
                timer11.Start();
            }
        }

        private void timer11_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 300)
            {
                timer11.Stop();
                MessageBox.Show("Çıkışa Ulaştınız. Tebrikler!!");
                Application.Exit();
            }
        }

        private void timer5_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 150)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 550)
            {
                timer6.Stop();
                timer7.Start();
            }
        }
    }

}
