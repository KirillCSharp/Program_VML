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
    public partial class Tic_tac_toe : Form
    {
        public Tic_tac_toe()
        {
            InitializeComponent();
        }

        public PictureBox[,] pb = new PictureBox[10, 10];

        private void Tic_tac_toe_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    pb[i, j] = new PictureBox();
                    Controls.Add(pb[i, j]);
                    pb[i, j].SetBounds(i * 50, j * 50, 45, 45);
                    pb[i, j].BackColor = Color.FromArgb(120, 120, 120);
                    pb[i, j].Click += Tic_tac_toe_Click;
                    pb[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        public bool IsC = true;
        public int[,] a = new int[10, 10];

        private void Tic_tac_toe_Click(object sender, EventArgs e)
        {
            if (IsC)
            {
                {
                    ((PictureBox)sender).Image = Image.FromFile("1.jpg");
                }
            }
            else
            {
                {
                    ((PictureBox)sender).Image = Image.FromFile("2.jpg");
                }
            }
            IsC = !IsC;
        }
        private void Tic_tac_toe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        pb[i, j].Image = null;
                    }
                }
            }
        }
    }
}
