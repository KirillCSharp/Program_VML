using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;

namespace Program_VML
{
    public partial class Archiver : Form
    {
        public Archiver()
        {
            InitializeComponent();
        }

        List<string> files = new List<string>();

        FileInfo[] a;

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OPD = new OpenFileDialog();
            if (OPD.ShowDialog() == DialogResult.OK)
            {
                files.Add(OPD.FileName);
            }
        }

        private void Archiver_Load(object sender, EventArgs e)
        {
            splitter1.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo DI = new DirectoryInfo(FBD.SelectedPath);
                FileInfo[] FI = DI.GetFiles();
                for (int i = 0; i < FI.Length; i++)
                {
                    files.Add(FI[i].ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZipFile ZF = new ZipFile();
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            DialogResult MBDR = DialogResult.OK;
            if (files.Count == 0)
            {
                MBDR = MessageBox.Show("Не выбрано ни одного файла для распаковки! Продолжить?", "Предупреждение", MessageBoxButtons.OKCancel);
            }
            if (MBDR == DialogResult.OK)
            {
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string path = FBD.SelectedPath;
                        for (int i = 0; i < files.Count; i++)
                        {
                            ZF.AddFile(path, "ZipFiles");
                        }
                        ZF.Save(path + "\\ZipFile.zip");
                    }
                    catch
                    {
                        MessageBox.Show("Error!");
                    }
                    files = new List<string>();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Zip Files (*.zip)|*.zip";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string pathZip = OFD.FileName;
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    string UnZipPath = FBD.SelectedPath;
                    using (ZipFile ZF = ZipFile.Read(pathZip))
                    {
                        ZF.ExtractAll(UnZipPath, ExtractExistingFileAction.DoNotOverwrite);
                    }
                }
            }
        }
    }
}
