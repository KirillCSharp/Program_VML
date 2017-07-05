using System;
using System.IO;
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
    public partial class NotePad : Form
    {
        public static string path = "-1";
        public static bool isSave = true;

        public NotePad()
        {
            InitializeComponent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            z:
            if (isSave)
            {
                path = "-1";
                isSave = true;
                textBox1.ReadOnly = false;
                textBox1.Text = "";
            }
            else
            {
                var res = MessageBox.Show("Сохранить ли предыдущий файл?", "Сохранение файла", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (path == "-1")
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            path = sfd.FileName;
                            File.WriteAllText(sfd.FileName, "");
                            isSave = true;
                        }
                        else
                        {
                            isSave = true;
                        }
                    }
                    else
                    {
                        File.WriteAllText(path, textBox1.Text);
                        isSave = true;
                    }
                    goto z;
                }
                isSave = true;
                goto z;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == "-1")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                    File.WriteAllText(sfd.FileName, "");
                    isSave = true;
                }
            }
            else
            {
                File.WriteAllText(path, textBox1.Text);
                isSave = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isSave = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g:
            if (isSave)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path1 = openFileDialog1.FileName;
                    textBox1.Text = File.ReadAllText(path1);
                    path = path1;
                    isSave = true;
                }
            }
            else
            {
                var res = MessageBox.Show("Сохранить ли предыдущий файл?", "Сохранение файла", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (path == "-1")
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            path = sfd.FileName;
                            File.WriteAllText(sfd.FileName, "");
                            isSave = true;
                        }
                        else
                        {
                            isSave = true;
                        }
                    }
                    else
                    {
                        File.WriteAllText(path, textBox1.Text);
                        isSave = true;
                    }
                    goto g;
                }
                isSave = true;
                goto g;
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qw:
            if (!isSave)
            {
                var res = MessageBox.Show("Сохранить ли предыдущий файл?", "Сохранение файла", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (path == "-1")
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            path = sfd.FileName;
                            File.WriteAllText(sfd.FileName, "");
                            isSave = true;
                        }
                        else
                        {
                            isSave = true;
                        }
                    }
                    else
                    {
                        File.WriteAllText(path, textBox1.Text);
                        isSave = true;
                    }
                }
                isSave = true;
                goto qw;
            }
            else
            {
                textBox1.ReadOnly = true;
                textBox1.Text = "";
                isSave = true;
                path = "-1";
            }
        }

        private void правкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}