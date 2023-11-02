using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //пространство имен для работы с файлами


namespace pr5_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                // Создание диалогового окна для сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Установка фильтра
                // Отображение диалогового окна и ожидание выбора файла пользователем
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName; // Получить имя выбранного файла

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        // Использование StreamWriter для записи текста в файл
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            foreach (string item in lst.Items) // Перебор элементов в ListBox
                            {
                                writer.WriteLine(item); // Запись каждого элемента в файл
                            }
                        }
                    }
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text; // Получение имени файла из текстового поля
            lstFromfile.Items.Clear(); // Очистка элементов в другом ListBox
                // Использование FileStream и BinaryReader для чтения из файла
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    while (br.PeekChar() != -1) // Пока в файле есть символ
                    {
                        lstFromfile.Items.Add(br.ReadString()); // Добавление каждой строки из файла в ListBox
                }
                    br.Close();
                    fs.Close();
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lst.Items.Add(txt.Text); // Добавление текста из TextBox в ListBox
            txt.Clear(); // Очистка TextBox после добавления
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}/*if- это условный оператор, который выполняет блокировку кода только в том случае,
  если условие, указанное внутри if, истинно (равномерно true). В противном случае код внутри ifзапускается
foreach- это цикл, который используется для перебора элементов в коллекциях, таких как массивы, упорядоченные,
словари и другие, без явного указания индексов или итераторов.
foreachудобно использовать для выполнения действий над каждым элементом коллекции.*/
