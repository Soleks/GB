using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeryNotVery
{
    public partial class Form1 : Form
    {
        TrueFalse database;

        public Form1()
        {
            InitializeComponent();
        }

        private void открытьИзТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void сохранитькакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void trackNumbers_Scroll(object sender, EventArgs e)
        {
            tsslNumberQuest.Text = trackNumbers.Value.ToString();
            tbQuest.Text = database[trackNumbers.Value - 1].Text;
            cbTrueFalse.Checked = database[trackNumbers.Value - 1].TrueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            database.Add("Пустой вопрос", false);
            trackNumbers.Minimum = 1;
            trackNumbers.Maximum = database.Count;
            trackNumbers.Value = database.Count;

            tsslNumberQuest.Text = trackNumbers.Value.ToString();
            tbQuest.Text = database[trackNumbers.Value - 1].Text;
            cbTrueFalse.Checked = database[trackNumbers.Value - 1].TrueFalse;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database[trackNumbers.Value - 1].Text = tbQuest.Text;
            database[trackNumbers.Value - 1].TrueFalse = cbTrueFalse.Checked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Вы хотите удалить вопрос ?", 
                "Внимание", 
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            database.Remove(trackNumbers.Value - 1);
            trackNumbers.Maximum = database.Count;
            tsslNumberQuest.Text = trackNumbers.Value.ToString();
            tbQuest.Text = database[trackNumbers.Value - 1].Text;
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info();
        }

        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            Info();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = false;
            this.cbTrueFalse.Enabled = false;
            this.trackNumbers.Enabled = false;
            this.сохранитьToolStripButton.Enabled = false;
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnableElements()
        {
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnSave.Enabled = true;
            this.cbTrueFalse.Enabled = true;
            this.trackNumbers.Enabled = true;
            this.сохранитьToolStripButton.Enabled = true;
        }

        private void Open()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файлы с вопросами(*.xml)|*.xml|Все файлы|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(dialog.FileName);
                database.Load(dialog.FileName);
                trackNumbers.Minimum = 1;
                trackNumbers.Maximum = database.Count;
                trackNumbers.Value = 1;
                tbQuest.Text = database[trackNumbers.Value - 1].Text;
                EnableElements();
            }
        }

        private void Save()
        {
            SaveFileDialog dialog = new SaveFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database.Save(dialog.FileName);
            }
        }

        private void Info()
        {
            MessageBox.Show("Автор: Олексенко С.С. Версия 1.1  Artistic License 2.0", "Инфо", MessageBoxButtons.OK);
        }
    }
}
