using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }

        private Doubler doubler_;
        private const string addition_ = "System.Windows.Forms.Button, Text: +1";
        private const string multiplication_ = "System.Windows.Forms.Button, Text: *2";

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "1";
            doubler_ = new Doubler();
            richTextBox2.Text = doubler_.Number.ToString();
        }

        private void BtnAddition(object sender, EventArgs e)
        {
            int n = int.Parse(richTextBox1.Text) + 1;

            richTextBox1.Text = n.ToString();

            if (doubler_.CheckWin(n, sender.ToString()) == Doubler.Win.fail)
            {
                MessageBox.Show("You lose");

                Form1_Load(sender, EventArgs.Empty);
            }

            if (doubler_.CheckWin(n, sender.ToString()) == Doubler.Win.win)
            {
                MessageBox.Show("You Win!!!");
                Form1_Load(sender, EventArgs.Empty);
            }
        }

        private void BtnMultiplication(object sender, EventArgs e)
        {
            int n = int.Parse(richTextBox1.Text) * 2;

            richTextBox1.Text = n.ToString();

            if (doubler_.CheckWin(n, sender.ToString()) == Doubler.Win.fail)
            {
                MessageBox.Show("You lose!!! HAHAHAHAHA...");
                Form1_Load(sender, EventArgs.Empty);
            }

            if (doubler_.CheckWin(n, sender.ToString()) == Doubler.Win.win)
            {
                MessageBox.Show("Congratulations!!! You Win!!!");
                Form1_Load(sender, EventArgs.Empty);
            }
        }

        private void BtnReset (object sender, EventArgs e)
        {
            richTextBox1.Text = "1";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, EventArgs.Empty);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbortLastMove_Click(object sender, EventArgs e)
        {
            if (doubler_.LastMove == addition_)
            {
                richTextBox1.Text = (doubler_.CurrentNumber - 1).ToString();

            } else if (doubler_.LastMove == multiplication_)
            {
                richTextBox1.Text = (doubler_.CurrentNumber / 2).ToString();
            }
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игрок управляет роботом, " +
                            "который может увеличить текущее значения на 1, " +
                            "умножить на 2, " +
                            "отменить последний ход, " +
                            "сбросить значение к 1. " +
                            "Цель: за меньшее количество " +
                            "ходов достичь загадонное число компьютером");
        }

        private void Version_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра удвоитель. Версия 1.0. Автор Олексенко С.С");
        }
    }
}
