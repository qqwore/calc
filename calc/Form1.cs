using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public string D;        // переменная для действия (+ - * /)
        public string N1;       // переменная для числа в текстбоксе
        public bool n2;         // флаг набора 2 числа
        public Form1()
        {
            n2 = false;         // обнуляем флаг набора 2 числа
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)          // кнопки с цифрами
        {
            if (n2)         // обработчик 2 числа в действии
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;         // если на табло 0, он убирается
            else
                textBox1.Text = textBox1.Text + B.Text;         // в другом случае дописывается цифра
        }

        private void button17_Click(object sender, EventArgs e)         // кнопка C
        {
            textBox1.Text = "0";        // обнуление табло с помощью кнопки C
        }

        private void button4_Click(object sender, EventArgs e)          // кнопки действия (+ - * /)
        {
            Button B = (Button)sender;
            D = B.Text;         // память действия
            N1 = textBox1.Text; // память числа 1
            n2 = true;          // триггер флага набора 2 числа     
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double dN1, dN2, res;       // переменные для вычислений и результата
            res = 0;
            dN1 = Convert.ToDouble(N1);
            dN2 = Convert.ToDouble(textBox1.Text);          // преобразования типа данных
            if (D == "+")       // далее операции вычисления
            {
                res = dN1 + dN2;

            }
            if (D == "-")
            {
                res = dN1 - dN2;

            }
            if (D == "*")
            {
                res = dN1 * dN2;

            }
            if (D == "/")
            {
                res = dN1 / dN2;

            }
            D = "=";
            n2 = true;
            textBox1.Text = res.ToString("F5");     // добавляем вывод результата, и количество цифр после запятой
        }
    }
}
