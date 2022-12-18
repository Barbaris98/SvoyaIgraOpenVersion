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
using System.Data.SQLite;
using Microsoft.Data.Sqlite;

namespace SvoyaIgraOpenVersion
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();

            string connectionString = "Data Source = MyTestGameDatabaseSQlite.db;";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                //MessageBox.Show(Path.GetFullPath("MyTestGameDatabaseSQlite.db"));

                //textBox1.Text = connection.State.ToString();

                string commandString = "SELECT QuestionText FROM Question WHERE IdQuestion = 21;";
                SqliteCommand sqlCommand = new SqliteCommand(commandString, connection);

                SqliteDataReader reader = sqlCommand.ExecuteReader();

                string myTextQuestion = string.Empty;
                while (reader.Read())
                {
                    myTextQuestion = reader.GetString(0);
                }



                textBox1.Text = myTextQuestion;

                connection.Close();
                reader.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = MyTestGameDatabaseSQlite.db;";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string commandString = "SELECT Answer FROM Question WHERE IdQuestion = 21;";
                SqliteCommand sqlCommand = new SqliteCommand(commandString, connection);

                SqliteDataReader reader = sqlCommand.ExecuteReader();

                string myTextQuestion = string.Empty;
                while (reader.Read())
                {
                    myTextQuestion = reader.GetString(0);
                }



                textBox2.Text = myTextQuestion;

                connection.Close();
                reader.Close();
            }

            //активровать кнопки приcуждения очков
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PointCount.point1 = PointCount.point1 + 100;

            // делаем загреивание нажатой кнопки
            button2.Enabled = false;
            // делаем загреивание остальных кнопок, чтоб присуждать очки
            // одной и только одной комаде
            if (button3.Enabled & button4.Enabled)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }

            //и закрываем форму
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PointCount.point2 = PointCount.point2 + 100;

            // делаем загреивание нажатой кнопки
            button3.Enabled = false;
            // делаем загреивание остальных кнопок, чтоб присуждать очки
            // одной и только одной комаде
            if (button2.Enabled & button4.Enabled)
            {
                button2.Enabled = false;
                button4.Enabled = false;
            }

            //и закрываем форму
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PointCount.point3 = PointCount.point3 + 100;

            // делаем загреивание нажатой кнопки
            button4.Enabled = false;
            // делаем загреивание остальных кнопок, чтоб присуждать очки
            // одной и только одной комаде
            if (button2.Enabled & button3.Enabled)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }

            //и закрываем форму
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
