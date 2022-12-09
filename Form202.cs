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
    public partial class Form202 : Form
    {
        public Form202()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Пухарев";


            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PointCount.point1 = PointCount.point1 + 300;

            // делаем загреивание нажатой кнопки
            button2.Enabled = false;
            // делаем загреивание остальных кнопок, чтоб присуждать очки
            // одной и только одной комаде
            if (button3.Enabled & button4.Enabled)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PointCount.point2 = PointCount.point2 + 300;

            // делаем загреивание нажатой кнопки
            button3.Enabled = false;
            // делаем загреивание остальных кнопок, чтоб присуждать очки
            // одной и только одной комаде
            if (button2.Enabled & button4.Enabled)
            {
                button2.Enabled = false;
                button4.Enabled = false;
            }

            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PointCount.point3 = PointCount.point3 + 300;

            // делаем загреивание нажатой кнопки
            button4.Enabled = false;
            // делаем загреивание остальных кнопок, чтоб присуждать очки
            // одной и только одной комаде
            if (button2.Enabled & button3.Enabled)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }

            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
