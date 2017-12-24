using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guessGame = new Guess();
            toolStripProgressBar1.Value = guessGame.CountTry;
            toolStripProgressBar1.Maximum = guessGame.CountTry;
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Введите число");

                return;
            }

            Результат.Text = guessGame.Try(int.Parse(textBox1.Text));
            textBox2.AppendText(textBox1.Text + " " + Результат.Text + "\r\n");

            if (guessGame.CountTry == -1)
            {
                MessageBox.Show("Вы проиграли");

                newGameToolStripMenuItem_Click(sender, EventArgs.Empty);

            } else
            {
                toolStripProgressBar1.Value = guessGame.CountTry;
            }

            textBox1.Text = "";
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
            newGameToolStripMenuItem_Click(sender, EventArgs.Empty);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Угадай число 1.0 Автор Олексенко С.С.");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра угадай число." +
                "Комптютер загадывает число, а игрок должен угадать его. Если число меньше загаднного компьютер подскажет \"Недалёт\"," +
                "если больше загаднного \"Перелёт\" " +
                "Если число угаданно, то игрок победил. " +
                "Количество попыток ограничено");
        }
    }
}
