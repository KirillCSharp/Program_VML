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
    public partial class notes : Form
    {
        public notes()
        {
            InitializeComponent();
        }

        private void notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.note = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void notes_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.note;
        }
    }
}
