using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Program_VML
{
    public partial class Chromium : Form
    {
        public ChromiumWebBrowser CB;

        public Chromium()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void Chromium_Load(object sender, EventArgs e)
        {

        }

        private void InitializeChromium()
        {
            CB = new ChromiumWebBrowser("http://google.com");
            CB.Dock = DockStyle.Fill;
            this.Controls.Add(CB);
        }

        private void Chromium_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Cef.Shutdown();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            //textBox1.Visible = true;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
           // textBox1.Visible = false;
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            //textBox1.Visible = true;
        }
    }
}
