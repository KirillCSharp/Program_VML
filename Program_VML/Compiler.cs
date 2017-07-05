using System;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
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
    public partial class Compiler : Form
    {
        public Compiler()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && Properties.Settings.Default.compiler != "-1")
            {
                string sProgram = textBox1.Text;
                var codeProvider = new CSharpCodeProvider(new Dictionary<string, string>() { {"CompilerVersion", "v3.5"} });
                var compilerParams = new CompilerParameters
                {
                    OutputAssembly = Properties.Settings.Default.compiler + "compiler.exe",
                    GenerateExecutable = true,
                };
                var results = codeProvider.CompileAssemblyFromSource(compilerParams, sProgram);
                string s = "";
                bool temp = false;
                for (int i = 0; i < results.Output.Count; i++)
                {
                    s += results.Output[i];
                    temp = true;
                }
                if (temp)
                {
                    MessageBox.Show(s);
                }
                else
                {
                    try
                    {
                        System.Diagnostics.Process.Start(Properties.Settings.Default.compiler + "compiler.exe");
                    }
                    catch
                    {

                    }
                }
            }
            else if (e.KeyCode == Keys.F11)
            {
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.compiler = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    System.IO.File.WriteAllText(sfd.FileName, textBox1.Text);
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string s = System.IO.File.ReadAllText(openFileDialog1.FileName);
                    textBox1.Text = s;
                }
            }
        }

        private void Compiler_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.example;
        }

        private void Compiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.example = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
