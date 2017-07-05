using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_VML
{
    public partial class Conf : Form
    {
        public Conf()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Conf_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject queryObj in searcher1.Get())
            {
                label1.Text += "Процессор: " + queryObj["Name"] + "\n";
                label2.Text += "Количество ядер: " + queryObj["NumberOfCores"]+ "\n";
            }
            if (label1.Width > label2.Width)
            {
                Width = label1.Width+ 10;
            }
            else
            {
                Width = label2.Width + 10;
            }
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach (ManagementObject queryObj in searcher2.Get())
            {
                label3.Text += "Видеокарта: " + queryObj["Caption"]+ "\n";
            }
            ManagementObjectSearcher searcher3= new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject queryObj in searcher3.Get())
            {
                label3.Text += "Модуль памяти: " + queryObj["BankLabel"] + "; Объем: " + Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2)  + "Gb; Скорость: " + queryObj["Speed"]+ "\n";
            }
        }
    }
}
