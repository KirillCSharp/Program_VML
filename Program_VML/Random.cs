using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_VML
{
    public partial class Random : Form
    {
        public Random()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            System.Random rnd = new System.Random();
            label5.Text = rnd.Next(a, b + 1).ToString();
        }

        public string last;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Text == "")
                {
                    return;
                }
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Только цифры!");
                ((TextBox)sender).Clear();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Text == "")
                {
                    return;
                }
                int s = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Только цифры!");
                ((TextBox)sender).Clear();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox3.Text);
            System.Random rnd = new System.Random();
            ((TextBox)sender).Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Text == "")
                {
                    return;
                }
                var s = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Только цифры и запятые!");
                ((TextBox)sender).Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Text == "")
                {
                    return;
                }
                var s = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Только цифры и запятые!");
                ((TextBox)sender).Clear();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Text == "")
                {
                    return;
                }
                var s = Convert.ToInt32(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Только цифры!");
                ((TextBox)sender).Clear();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox5.Text);
            string s = "";
            System.Random rnd = new System.Random();
            for (int i = 0; i < c; i++)
            {
                int a = rnd.Next(1, 3);
                if (a == 1)
                {
                    s += Convert.ToChar(rnd.Next('a', 'z' + 1)).ToString();
                }
                else
                {
                    s += rnd.Next(1, 10).ToString();
                }
            }
            label15.Text = s;
            this.Width = label15.Location.X + label15.Width + 10;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
