using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Program_VML
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "pow(" + textBox1.Text + ", 3)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "pow" + textBox1.Text + ", 2)";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = "pow(" + textBox1.Text + ", 1/2)";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Math.PI.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Math.E.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Pow(";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Sin(";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Cos(";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Tan(";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "cTg(";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "(";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ")";
        }

        private void button21_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "(" + textBox1.Text + ")!";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private async void button16_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                var result = await CSharpScript.EvaluateAsync(input, ScriptOptions.Default.WithImports("System.Math"));
                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "Ошибка!";
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "Log(";
        }

        private async void calc_LoadAsync(object sender, EventArgs e)
        {
            await CSharpScript.EvaluateAsync("1+1", ScriptOptions.Default.WithImports("System.Math"));
        }
    }
}
