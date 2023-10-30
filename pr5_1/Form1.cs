using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Показывает диалог открытия файла. Если пользователь нажмет кнопку ОК, загрузится, выбранная картинка
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                info.Text = openFileDialog1.FileName; // Выводится полное имя файла в TextBox
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Показывает диалоговое окно цвета. Если пользователь нажмет кнопку ОК, изменится, на выбранный фон 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Если флажок растянуть,меняется PictureBox
            // Свойству SizeMode присвоено значение «Растянуть». Если пользователь очищает флажок, меняет его на стандартный
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void savefile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) /*открывается окно "SaveFileDialo"
             "DialogResult.OK"гарантирует, что пользователь действительно выбрал место и имя файла*/
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName); // Сохраняем изображение
            }
        }

        private void openForm2Button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Создание экземпляра Form2
            form2.Show(); // Открыть Form2
        }
    }
}
