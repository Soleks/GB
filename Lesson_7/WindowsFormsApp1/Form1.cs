using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Guess guessGame;

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            guessGame = new Guess();
            toolStripProgressBar1.Value = guessGame.CountTry;
            toolStripProgressBar1.Maximum = guessGame.CountTry;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(textBox1.Text + " ");
            label1.Text = guessGame.Try(int.Parse(textBox1.Text));
            toolStripProgressBar1.Value = guessGame.CountTry;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem2_Click(sender, EventArgs.Empty);
        }
    }
}
