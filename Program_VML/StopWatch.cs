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
    public partial class StopWatch : Form
    {
        public StopWatch()
        {
            InitializeComponent();
        }

        public int Sec = 0;
        public int Min = 0;
        public int hour = 0;
        public bool isStart = false;
        public bool isPause = false;
        public bool tap = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isPause)
            {
                if (Sec < 60)
                {
                    Sec++;
                }
                else if (Min < 60)
                {
                    Min++;
                    Sec = 0;
                }
                else
                {
                    hour++;
                    Min = 0;
                    Sec = 0;
                }
                string out1 = "";
                string out2 = "";
                string out3 = "";
                if (Sec < 10)
                {
                    out1 = "0" + Sec.ToString();
                }
                else
                {
                    out1 = Sec.ToString();
                }
                if (Min < 10)
                {
                    out2 = "0" + Min.ToString();
                }
                else
                {
                    out2 = Min.ToString();
                }
                if (hour < 10)
                {
                    out3 = "0" + Min.ToString();
                }
                else
                {
                    out3 = hour.ToString();
                }
                label1.Text = out3 + ":" + out2 + ":" + out1;
            }
        } 

        private void StopWatch_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                Sec = 0;
                Min = 0;
                hour = 0;
                timer1.Enabled = true;
                isStart = true;
                isPause = false;
                this.Height += 30;
                button2.Visible = true;
                button1.Text = "Стоп!";
                label1.ForeColor = Color.White;
            }
            else
            {
                isStart = !isStart;
                timer1.Enabled = false;
                isPause = false;
                this.Height -= 30;
                button2.Visible = false;
                button1.Text = "Старт!";
                label1.ForeColor = Color.Lime;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isPause)
            {
                label1.ForeColor = Color.White;
                button2.Text = "Пауза";
            }
            else
            {
                label1.ForeColor = Color.Yellow;
                button2.Text = "Продолжить";
            }
            isPause = !isPause;
        }
    }
}

