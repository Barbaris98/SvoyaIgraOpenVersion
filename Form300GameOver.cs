using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvoyaIgraOpenVersion
{
    public partial class Form300GameOver : Form
    {
        public Form300GameOver()
        {
            InitializeComponent();
        }


        //на всякий кнопка принудительнойго показа результата
        private void button1_Click(object sender, EventArgs e)
        {
            // записали в первый текст бокс
            if (PointCount.point1 > (PointCount.point2 | PointCount.point3))
            {
                textBox1.Text = "1";
            }
            else if (PointCount.point2 > (PointCount.point1 | PointCount.point3))
            {
                textBox1.Text = "2";
            }
            else if (PointCount.point3 > (PointCount.point1 | PointCount.point2))
            {
                textBox1.Text = "3";
            }

            //записали во второй текст бокс
            if (PointCount.point1 > (PointCount.point2 | PointCount.point3))
            {
                textBox2.Text = "1";
            }
            else if (PointCount.point2 > (PointCount.point1 | PointCount.point3))
            {
                textBox2.Text = "2";
            }
            else if (PointCount.point3 > (PointCount.point1 | PointCount.point2))
            {
                textBox2.Text = "3";
            }

            // Испраляем совпадение, чтоб не было два раза указания команды что она победила-она победила
            if (textBox1.Text == textBox2.Text & textBox1.Text == "1")
            {
                if (PointCount.point1 > PointCount.point2)
                {
                    textBox2.Text = "2";
                }
                else
                {
                    textBox2.Text = "3";
                }
            }

            if (textBox1.Text == textBox2.Text & textBox1.Text == "2")
            {
                if (PointCount.point1 > PointCount.point2)
                {
                    textBox2.Text = "1";
                }
                else
                {
                    textBox2.Text = "3";
                }
            }

            if (textBox1.Text == textBox2.Text & textBox1.Text == "3")
            {
                if (PointCount.point1 > PointCount.point2)
                {
                    textBox2.Text = "1";
                }
                else
                {
                    textBox2.Text = "2";
                }
            }
        }


        private void Form300GameOver_Load(object sender, EventArgs e)
        {
            // записали в первый текст бокс
            if (PointCount.point1 > (PointCount.point2 | PointCount.point3))
            {
                textBox1.Text = "1";
            }
            else if (PointCount.point2 > (PointCount.point1 | PointCount.point3))
            {
                textBox1.Text = "2";
            }
            else if (PointCount.point3 > (PointCount.point1 | PointCount.point2))
            {
                textBox1.Text = "3";
            }

            //записали во второй текст бокс
            if (PointCount.point1 > (PointCount.point2 | PointCount.point3))
            {
                textBox2.Text = "1";
            }
            else if (PointCount.point2 > (PointCount.point1 | PointCount.point3))
            {
                textBox2.Text = "2";
            }
            else if (PointCount.point3 > (PointCount.point1 | PointCount.point2))
            {
                textBox2.Text = "3";
            }

            // Испраляем совпадение, чтоб не было два раза указания команды что она победила-она победила
            if (textBox1.Text == textBox2.Text & textBox1.Text == "1")
            {
                if (PointCount.point1 > PointCount.point2)
                {
                    textBox2.Text = "2";
                }
                else
                {
                    textBox2.Text = "3";
                }
            }

            if (textBox1.Text == textBox2.Text & textBox1.Text == "2")
            {
                if (PointCount.point1 > PointCount.point2)
                {
                    textBox2.Text = "1";
                }
                else
                {
                    textBox2.Text = "3";
                }
            }

            if (textBox1.Text == textBox2.Text & textBox1.Text == "3")
            {
                if (PointCount.point1 > PointCount.point2)
                {
                    textBox2.Text = "1";
                }
                else
                {
                    textBox2.Text = "2";
                }
            }
        }
    }
}
