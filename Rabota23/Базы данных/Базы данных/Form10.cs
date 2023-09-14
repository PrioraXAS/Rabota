using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Базы_данных
{
    public partial class Form10 : Form
    {
        private SQLiteConnection DB;
        public Form10()
        {
            InitializeComponent();
        }

        private async void Form10_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connectionString);
            await DB.OpenAsync();
            LoadingDB();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form users = new Form2();
            users.Show();
            users.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private async void LoadingDB()
        {
            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{table_mir.main}]", DB); // берем данные для dataGridview из таблицы table_Users
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[4]); // вывод данных по столбцам

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{table_mir.ID}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{table_mir.Name}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{table_mir.Surname}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{table_mir.Surname2}"]}");
                }
                foreach (string[] s in data)
                {
                    _ = dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form users = new Form9();
            users.Show();
            users.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
    }
}
