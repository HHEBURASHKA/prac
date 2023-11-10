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
        private int[] Arr = new int[10];
        private void btnNewArr_Click(object sender, EventArgs e)
        {
            int n = 10;
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            Random r = new Random(); //Создание объекта для генерации случайных чисел.
            for (int i = 0; i < n; i++) //Создание объекта для генерации случайных чисел.
            {
                Arr[i] = r.Next(a, b); //Заполнение текущего элемента массива случайными числами в заданном отношении.
                lblArr.Text += Arr[i];
                if (i != n) lblArr.Text += ","; //Добавление запятой, если данный элемент не последний.
            }
            btnSort.Enabled = true; //Разблокировка кнопки сортировки.
            textBox1.Text = n.ToString(); // Отображение количества используемых чисел (думая наперед пишу, что n это переменная заданная выше)
        }
        private int MinNumber(int[] x, int m) //Эту часть кода видимо писал под снюсом, сами видели :)
        {
            int min = x[m];
            int MinN = m; //Короче эта часть кода приводит к состоянию готовности минимальный элемент в оставшейся части массива
            for (int i = m; i < x.Length; i++) //Цикл определения минимального элемента в оставшейся части массива
            {
                if (x[i] < min) //Обновление минимального элемента и его индекса
                {
                    min = x[i];
                    MinN = i;
                }
            }
            return MinN; //Возвращаем индекс мин элемента
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int k, t; //Короче эта часть кода приводит к состоянию готовности 
            for (int i=0; i<Arr.Length; i++) /* Короче i приравнивается к 0, и постепенно увеличивается на 1,
                                              и цикл будет продолжаться пока i не дойдет до значения длины массива, в данном случае это 10*/
            {
                k=MinNumber(Arr,i);
                t = Arr[i]; //Временная переменная принимает значение
                Arr[i] = Arr[k]; // i заменяется на мин значение из предыдущего шага 
                Arr[k] = t; // Значение из предыдущего шага заменятеся на значение из временной переменной 
                lblResult.Text += Arr[i]; //Добавление текущего элемента в текстовое поле 
                if (i != Arr.Length -1) { lblResult.Text += ","; } //Добавление запятой, если данный элемент не последний
            }
            btnSort.Enabled=false; //Блокировка кнопки сортировки

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
