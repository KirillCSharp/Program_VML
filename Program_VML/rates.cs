using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;

namespace Program_VML
{
    public partial class rates : Form
    {
        public rates()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double from = Convert.ToDouble(textBox1.Text);
                var br = new WebClient();
                string site = br.DownloadString("https://finance.rambler.ru/currencies/USD/");
                var rx = new Regex(@"<div class=""exr-top-info__val"">[0-9,]{0,9}<\/div>");
                string m = rx.Match(site).ToString().Remove(0,31).Remove(7,6);
                double rate = Convert.ToDouble(m);
                textBox2.Text = (rate * from).ToString();
            }
            catch
            {
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double from = Convert.ToDouble(textBox3.Text);
                var br = new WebClient();
                string site = br.DownloadString("https://finance.rambler.ru/currencies/EUR/");
                var rx = new Regex(@"<div class=""exr-top-info__val"">[0-9,]{0,9}<\/div>");
                string m = rx.Match(site).ToString().Remove(0, 31).Remove(7, 6);
                double rate = Convert.ToDouble(m);
                textBox4.Text = (rate * from).ToString();
            }
            catch
            {
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double from = Convert.ToDouble(textBox5.Text);
                var br = new WebClient();
                string site = br.DownloadString("https://finance.rambler.ru/currencies/GBP/");
                var rx = new Regex(@"<div class=""exr-top-info__val"">[0-9,]{0,9}<\/div>");
                string m = rx.Match(site).ToString().Remove(0, 31).Remove(7, 6);
                double rate = Convert.ToDouble(m);
                textBox6.Text = (rate * from).ToString();
            }
            catch
            {
            }
        }
    }
}
