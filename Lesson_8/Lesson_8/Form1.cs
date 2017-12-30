using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Believe game_;

        private void butTrue_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender + e.ToString());

            game_.RunGame(sender);

            textBox1.Text = game_.Value;

            if (game_.CheckWin == 4)
            {
                MessageBox.Show("Победа " + game_.Number);
            }
            else
            {
                MessageBox.Show("Поражение " + game_.Number);
            }
        }

        private void butFalse_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender + e.ToString());

            game_.RunGame(sender);

            textBox1.Text = game_.Value;

            if (game_.CheckWin == 4)
            {
                MessageBox.Show("Поражение " + game_.Number);

            } else
            {
                MessageBox.Show("Победа " + game_.Number);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            game_ = new Believe();
            textBox1.Text = game_.Value;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Олексенко С.С. Версия: 0.1 artistic license 2.0 " + 
                            "Демо версия игры \"Верю не верю.\"");
        }
    }
}
