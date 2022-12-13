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
using Microsoft.Data.Sqlite;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Data.SqlClient;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;


namespace SvoyaIgraOpenVersion
{
    public partial class Form200 : Form
    {
        public Form200()
        {
            InitializeComponent();
        }

        private void Form200_Load(object sender, EventArgs e)
        {

            string connectionString = "Data Source = MyTestGameDatabaseSQlite.db;";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string commandString = "SELECT * FROM Question";
                SqliteCommand sqlCommand = new SqliteCommand(commandString, connection);

                SqliteDataReader reader = sqlCommand.ExecuteReader();


                //Каждая строка будет пред собой массив состощий из 4-ёх элементов
                // тк. 4 столбца
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    //буем доб новую строку в список
                    data.Add(new string[5]);


                    // не совсем понял, но гдето я это видел, у Шевчука
                    // такой в обратку уменьш порядок....ну ты понял
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();
                connection.Close();
                //reader.Close();
                //

                // теперь заполняем
                foreach (string[] stringView in data)
                {
                    dataGridView1.Rows.Add(stringView);
                }

            }

        }

        private void Form200_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            Hide();

        }


        // экспорт
        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;

            for (i = 0; i <= dataGridView1.RowCount - 2; i++ )
            { 
                for(j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1 , j + 1] = dataGridView1[j, i].Value.ToString();
                }

            }

            //сразу откроется Эксель файл
            exApp.Visible = true;

        }
    }
}
