using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Program_VML
{
    public partial class HTML : Form
    {
        public HTML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            X:
            if (path.StartsWith("http://") || path.StartsWith("https://"))
            {
                var wc = new WebClient();
                textBox2.Text = wc.DownloadString(path);
            }
            else
            {
                path = "http://" + path;
                textBox1.Text = path;
                goto X;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
