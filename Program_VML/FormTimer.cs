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
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        public  int Sec;
        public int Min;
        public int Hour;
        /*public static int this.Sec0 = 0;
        public static int this.Min0 = 0;
        public static int this.Hour0 = 0;*/
        public bool isStart = false;
        public static int Count = 0;
        public int thisCount;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                string s = dateTimePicker1.Text;
                string[] temp = s.Split(':');
                int[] a = new int[temp.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    a[i] = Convert.ToInt32(temp[i]);
                }
                this.Sec = a[2];
                this.Min = a[1];
                this.Hour = a[0];
                isStart = true;
                Count++;
                thisCount = Count;
                button1.Text = "Отмена!";
            }
            else
            {
                isStart = false;
                button1.Text = "Запустить таймер №" + (Count + 1).ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isStart)
            {
                if (this.Sec == 0)
                {
                    if (this.Min == 0)
                    {
                        if (Hour == 0)
                        {
                            button1.Text = "Запустить!";
                            isStart = false;
                            MessageBox.Show("Звенит таймер №" + thisCount.ToString());
                            Count--;
                        }
                        else
                        {
                            this.Hour--;
                            this.Min = 59;
                            this.Sec = 59;
                        }
                    }
                    else
                    {
                        this.Min--;
                        this.Sec = 59;
                    }
                }
                else
                {
                    this.Sec--;
                }
                string out1 = "", out2 = "", out3 = "";
                if (this.Sec < 10)
                {
                    out1 = "0" + this.Sec.ToString();
                }
                else
                {
                    out1 = this.Sec.ToString();
                }
                if (this.Min < 10)
                {
                    out2 = "0" + this.Min.ToString();
                }
                else
                {
                    out2 = this.Min.ToString();
                }
                if (this.Hour < 10)
                {
                    out3 = "0" + this.Min.ToString();
                }
                else
                {
                    out3 = this.Hour.ToString();
                }
                dateTimePicker1.Text = out3 + ":" + out2 + ":" + out1;
            }
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!isStart)
            {
                button1.Text = "Запустить таймер №" + (Count + 1).ToString();
            }
        }
    }
}
