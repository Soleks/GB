using System;
using System.Windows.Forms;

namespace CTX
{
    public partial class CsvToXml : Form
    {
        public CsvToXml()
        {
            InitializeComponent();
        }

        private HandlerBigData bigData_;

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файлы csv(*.csv)|*.csv";

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            bigData_ = new HandlerBigData(dialog.FileName);
            bigData_.CreateList();

            while (!bigData_.Load)
            {
                button2.Enabled = false;
            }

            textBox1.Text = "Файл загружен";
            button2.Enabled = true;
        }

        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Конвертор csv to xml Автор: Олексенко С.С. Версия: 1.0 artistic license 2.0");
        }

        private void CsvToXml_Click(object sender, EventArgs e)
        {
            if (!bigData_.CsvToXml())
            {
                return;
            }
            else
            {
                MessageBox.Show("Процесс завершён");
            }

            textBox1.Text = "";
        }
    }
}
