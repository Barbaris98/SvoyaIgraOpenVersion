using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
//using System.Threading;

namespace SvoyaIgraOpenVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            form2 = new Form2();//созд
            form2_ = new Form2_();
            form3 = new Form3();
            form4 = new Form4();
            form5 = new Form5();

            form6 = new Form6();
            form7 = new Form7();
            form8 = new Form8();
            form9 = new Form9();
            form10 = new Form10();

            form11 = new Form11();//третий блок вопросов "Клейма"
            form12 = new Form12(); 
            form13 = new Form13();
            form14 = new Form14();
            form15 = new Form15(); 

            form16 = new Form16();//4 блок вопросов "На разогреве"
            form17 = new Form17();
            form18 = new Form18();
            form19 = new Form19();
            form20 = new Form20();

            form21 = new Form21(); //5 блок вопросов "Это база"
            form22 = new Form22();
            form23 = new Form23();
            form24 = new Form24();
            form25 = new Form25();

            form200 = new Form200(); //отчёт

            form201 = new Form201(); //КТО?
            form202 = new Form202();
            form203 = new Form203();

            form26 = new Form26(); //5 блок вопросов "Сертификация"
            form27 = new Form27();
            form28 = new Form28();
            form29 = new Form29();
            form30 = new Form30();

            form31 = new Form31(); // вопросов "Калибры"
            form32 = new Form32();
            form33 = new Form33();
            form34 = new Form34();
            form35 = new Form35();

            form36 = new Form36(); // вопросов "длинное названиие"
            form37 = new Form37();
            form38 = new Form38();
            form39 = new Form39();
            form40 = new Form40();

            form41 = new Form41(); // вопросов "пневматика"
            form42 = new Form42();
            form43 = new Form43();
            form44 = new Form44();
            form45 = new Form45();

            form46 = new Form46(); // вопросов "пневматика тонксти"
            form47 = new Form47();
            form48 = new Form48();
            form49 = new Form49();
            form50 = new Form50();

            form300GameOver = new Form300GameOver(); //Game over
        }

        Form2 form2;  //привязали к первой  форме
        Form2_ form2_;
        Form3 form3;
        Form4 form4;
        Form5 form5;

        Form6 form6;
        Form7 form7;
        Form8 form8;
        Form9 form9;
        Form10 form10;

        Form11 form11;
        Form12 form12;
        Form13 form13;
        Form14 form14;
        Form15 form15;

        Form16 form16;
        Form17 form17;
        Form18 form18;
        Form19 form19;
        Form20 form20;

        Form21 form21;
        Form22 form22;
        Form23 form23;
        Form24 form24;
        Form25 form25;

        Form200 form200;
        Form201 form201;
        Form202 form202;
        Form203 form203;

        Form300GameOver form300GameOver;

        Form26 form26;
        Form27 form27;
        Form28 form28;
        Form29 form29;
        Form30 form30;

        Form31 form31;
        Form32 form32;
        Form33 form33;
        Form34 form34;
        Form35 form35;

        Form36 form36;
        Form37 form37;
        Form38 form38;
        Form39 form39;
        Form40 form40;

        Form41 form41;
        Form42 form42;
        Form43 form43;
        Form44 form44;
        Form45 form45;

        Form46 form46;
        Form47 form47;
        Form48 form48;
        Form49 form49;
        Form50 form50;

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.FormClosed += (s, e1) => button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2_.Show();
            form2_.FormClosed += (s, e1) => button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form3.Show();
            form3.FormClosed += (s, e1) => button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form4.Show();
            form4.FormClosed += (s, e1) => button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form5.Show();
            form5.FormClosed += (s, e1) => button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            form6.Show();
            form6.FormClosed += (s, e1) => button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            form7.Show();
            form7.FormClosed += (s, e1) => button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form8.Show();
            form8.FormClosed += (s, e1) => button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            form9.Show();
            form9.FormClosed += (s, e1) => button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            form10.Show();
            form10.FormClosed += (s, e1) => button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            form11.Show();
            form11.FormClosed += (s, e1) => button11.Enabled = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            form12.Show();
            form12.FormClosed += (s, e1) => button12.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            form13.Show();
            form13.FormClosed += (s, e1) => button13.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            form14.Show();
            form14.FormClosed += (s, e1) => button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            form15.Show();
            form15.FormClosed += (s, e1) => button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            form16.Show();
            form16.FormClosed += (s, e1) => button16.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            form17.Show();
            form17.FormClosed += (s, e1) => button17.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            form18.Show();
            form18.FormClosed += (s, e1) => button18.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            form19.Show();
            form19.FormClosed += (s, e1) => button19.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            form20.Show();
            form20.FormClosed += (s, e1) => button20.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            form21.Show();
            form21.FormClosed += (s, e1) => button21.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            form22.Show();
            form22.FormClosed += (s, e1) => button22.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            form23.Show();
            form23.FormClosed += (s, e1) => button23.Enabled = false;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            form24.Show();
            form24.FormClosed += (s, e1) => button24.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            form25.Show();
            form25.FormClosed += (s, e1) => button25.Enabled = false;
        }


        // обновить
        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                textBox1.Text = PointCount.point1.ToString();

            }

            if (textBox2 != null)
            {
                textBox2.Text = PointCount.point2.ToString();

            }

            if (textBox3 != null)
            {
                textBox3.Text = PointCount.point3.ToString();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show(
        "Закрыть приложение?",
        "Закрытие",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Error,
        MessageBoxDefaultButton.Button2,
        MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                //Close(); будет просто закрыться MessageBox, тк на НЁМ ты его вызываешь !
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            };

        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo procInfo = new ProcessStartInfo();
            // исполняемый файл программы - браузер хром
            procInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome";
            // аргументы запуска - адрес интернет-ресурса
            procInfo.Arguments = "https://vk.com/dimaruss195";
            Process.Start(procInfo);
        }

        private void создатьОтчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form200.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            form201.Show();
            form201.FormClosed += (s, e1) => button27.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            form202.Show();
            form202.FormClosed += (s, e1) => button28.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            form203.Show();
            form203.FormClosed += (s, e1) => button29.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            form300GameOver.Show();
            form300GameOver.FormClosed += (s, e1) => button30.Enabled = false;
        }
        //
        private void button31_Click(object sender, EventArgs e)
        {
            form26.Show();
            form26.FormClosed += (s, e1) => button26_.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            form27.Show();
            form27.FormClosed += (s, e1) => button27_.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            form28.Show();
            form28.FormClosed += (s, e1) => button28_.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            form29.Show();
            form29.FormClosed += (s, e1) => button29_.Enabled = false;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            form30.Show();
            form30.FormClosed += (s, e1) => button30_.Enabled = false;
        }

        //Калибры
        private void button31_Click_1(object sender, EventArgs e)
        {
            form31.Show();
            form31.FormClosed += (s, e1) => button31.Enabled = false;
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            form32.Show();
            form32.FormClosed += (s, e1) => button32.Enabled = false;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            form33.Show();
            form33.FormClosed += (s, e1) => button33.Enabled = false;
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            form34.Show();
            form34.FormClosed += (s, e1) => button34.Enabled = false;
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            form35.Show();
            form35.FormClosed += (s, e1) => button35.Enabled = false;
        }


        //длинное название
        private void button36_Click(object sender, EventArgs e)
        {
            form36.Show();
            form36.FormClosed += (s, e1) => button36.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            form37.Show();
            form37.FormClosed += (s, e1) => button37.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            form38.Show();
            form38.FormClosed += (s, e1) => button38.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            form39.Show();
            form39.FormClosed += (s, e1) => button39.Enabled = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            form40.Show();
            form40.FormClosed += (s, e1) => button40.Enabled = false;
        }
        //пневматика
        private void button41_Click(object sender, EventArgs e)
        {
            form41.Show();
            form41.FormClosed += (s, e1) => button41.Enabled = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            form42.Show();
            form42.FormClosed += (s, e1) => button42.Enabled = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            form43.Show();
            form43.FormClosed += (s, e1) => button43.Enabled = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            form44.Show();
            form44.FormClosed += (s, e1) => button44.Enabled = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            form45.Show();
            form45.FormClosed += (s, e1) => button45.Enabled = false;
        }


        //пневматика тонкости
        private void button46_Click(object sender, EventArgs e)
        {
            form46.Show();
            form46.FormClosed += (s, e1) => button46.Enabled = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            form47.Show();
            form47.FormClosed += (s, e1) => button47.Enabled = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            form48.Show();
            form48.FormClosed += (s, e1) => button48.Enabled = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            form49.Show();
            form49.FormClosed += (s, e1) => button49.Enabled = false;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            form50.Show();
            form50.FormClosed += (s, e1) => button50.Enabled = false;
        }
    }
}
