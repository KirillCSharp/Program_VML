using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Program_VML
{
    public partial class NotePadHTML : Form
    {
        public NotePadHTML()
        {
            InitializeComponent();
        }

        public FastColoredTextBox tb = new FastColoredTextBox();
        
        private void NotePadHTML_Load(object sender, EventArgs e)
        {
            Controls.Add(tb);
            tb.Language = Language.HTML;
            tb.Dock = DockStyle.Fill;
            tb.KeyDown += Tb_KeyDown;
        }

        private void Tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                var SFD = new SaveFileDialog();
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string path = SFD.FileName;
                        System.IO.File.WriteAllText(path, tb.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                }
            }
            else if (e.KeyCode == Keys.O && e.Control)
            {
                var OFD = new OpenFileDialog();
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    string path = OFD.FileName;
                    tb.Text = System.IO.File.ReadAllText(path);
                }
            }
        }
    }
}
