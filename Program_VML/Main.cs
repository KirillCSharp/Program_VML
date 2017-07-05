using System;
using System.Diagnostics;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var f = new calc();
            f.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var f = new Chromium();
            f.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            var f = new IE();
            f.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var f = new HTML();
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var f = new NotePad();
            f.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var f = new Random();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var f = new notes();
            f.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var f = new rates();
            f.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new StopWatch();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var f = new Compiler();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new FormTimer();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new Archiver();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var f = new Tic_tac_toe();
            f.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var f = new Conf();
            f.Show();
        }
    }
}
