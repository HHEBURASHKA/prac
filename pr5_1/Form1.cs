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
        private int NumberSymbols(string stroka, char symbol)
        {
            int k = 0;
            //проверка каждого символа в строке 
            for (int i = 0; i<stroka.Length; i++)
            {
                //если текущий символ равен заданному символу, увеличиваем счетчик
                if (stroka[i] == symbol)
                {
                    k += 1;
                }
            }
            return k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //получаем входную строку из текстового поля
            string input = textBox1.Text;
            //получаем символ из текстового поля и берем первый символ (если есть конечно)
            char symbol = textBox4.Text[0];
            //вызываем не аркадия паровозова конечно, но метод по подсчету количества заданного символа в строке
            int count = NumberSymbols(input, symbol);
            //вывод в textBox (такая панелька на форме)
            textBox2.Text = count.ToString();
            //даем переменную для сочетания "ма"
            int maCount = 0;
            //запускаем супер мега цикл, который проходит по каждому символу в строке, проверяя пары символов "м" и "а"
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == 'м' && input[i +1] == 'а')
                {
                    maCount++;
                }
            }
            //выводим в textBox (такая панелька на форме)
            textBox3.Text = maCount.ToString();  
        }
    }

}
