using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace readwritefiletext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numefila = "";

        public Color fc, bc;
        public Font font0;


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
           
                numefila = openFileDialog1.FileName;
                Text = numefila;

              try
            {
                FileStream fs = new FileStream(numefila, FileMode.Open);
                fs.Close();

                string[] linii = File.ReadAllLines(numefila);


                for (int i = 0; i < linii.Length; i++)
                {
                    textBox1.Text += linii[i] + "\r\n";


                }
            }
              catch { }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab0 = new AboutBox1();
            ab0.Left = this.Left + 300;
            ab0.Top = this.Top + 300;
            ab0.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (numefila != "")
            {
                numefila = saveFileDialog1.FileName;
            }
            else
            {
                numefila = saveFileDialog1.FileName;
            }
            Text = numefila;
            try
            {
                File.WriteAllLines(numefila, textBox1.Lines);
            }
            catch { }




            
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            bc = colorDialog1.Color;
            textBox1.BackColor = bc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            font0 = textBox1.Font;

        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            fc = colorDialog1.Color;
            textBox1.ForeColor = fc;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            font0 = fontDialog1.Font;
            textBox1.Font = font0;
        }
    }
}
