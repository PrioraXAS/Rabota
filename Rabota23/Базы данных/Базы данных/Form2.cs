using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Базы_данных
{
    public partial class Form2 : Form
    {
        private SQLiteConnection DB;
        public Form2()
        {
            InitializeComponent();
            {
               
            }
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connectionString);
            await DB.OpenAsync();
            LoadingDB();
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private async void LoadingDB()
        {
            dataGridView2.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{table_photos.main}]", DB); // берем данные для dataGridview из таблицы table_Users
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]); // вывод данных по столбцам

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{table_photos.ID}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{table_photos.photos}"]}");

                }
                foreach (string[] s in data)
                {
                    _ = dataGridView2.Rows.Add(s);
                }
                dataGridView2.ClearSelection();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"{ex.Message}", $"{ex.Source}");
            }
            finally
            {
                sqlReader?.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form users = new Form3();
            users.Show();
            users.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form users = new Form4();
            users.Show();
            users.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form users = new Form5();
            users.Show();
            users.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form users = new Form7();
            users.Show();
            users.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form users = new Form8();
            users.Show();
            users.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
    }
}
