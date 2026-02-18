using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string link;
        public void haber(string link)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader(link);
            while (xmloku.Read())
            {
                if (xmloku.NodeType == XmlNodeType.Element && xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            link = "http://www.hurriyet.com.tr/rss/anasayfa";
            haber(link);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            link = "http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml";
            haber(link);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            link = "http://www.cumhuriyet.com.tr/rss/son_dakika.xml";
            haber(link);
        }
        
    }
}
