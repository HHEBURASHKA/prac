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
        private int seconds = 0;
        private int minutes = 0;
        

        public Form1()
        {//задается интервал для таймера tmrSecundomer
            InitializeComponent();
            tmrSecundomer.Interval = 1000;
         //добавляет обработчик события Tick для таймера tmrSecundomer.
         //Когда происходит событие Tick, будет вызываться метод tmrSecundomer_Tick
            tmrSecundomer.Tick += new EventHandler(tmrSecundomer_Tick);
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            //Внутри этого метода происходит увеличение счетчика секунд и минут,
            //а также обновление текстовых полей txtSeconds и txtMinutes на форме.
            
            seconds++;

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            txtSeconds.Text = seconds.ToString();
            txtMinutes.Text = minutes.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Если таймер включен, он отключает его и меняет текст кнопки на "Start".
            //Если таймер выключен, он включает его и меняет текст кнопки на "Stop"
            if (tmrSecundomer.Enabled)
            {
                tmrSecundomer.Enabled = false;
                btnStart.Text = "Start";
            }
            else
            {
                tmrSecundomer.Enabled = true;
                btnStart.Text = "Stop";
            }
            
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            //сброс значений счетчиков секунд и минут в ноль, а также обновление текстовых полей txtSeconds
            //и txtMinutes на форме, чтобы отобразить новые значения
            seconds = 0;
            minutes = 0;
            txtSeconds.Text = "0";
            txtMinutes.Text = "0";
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            //создает окно сообщения MessageBox и отображает текущее время (часы, минуты, секунды) в формате "HH:mm:ss"
            MessageBox.Show(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
