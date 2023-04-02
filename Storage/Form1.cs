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
using System.IO;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Storage
{
    public partial class Form1 : Form
    {
        private string path2sqlCreate = Environment.CurrentDirectory + "\\Create.sql";
        private string path2sqlInsert = Environment.CurrentDirectory + "\\Insert.sql";
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                string connectionString = $"Data Source=***;Initial Catalog=***;User ID=***;Password=***;Pooling=True;";
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                builder.DataSource = comboBoxServer.Text;
                builder.InitialCatalog = "master";
                builder.UserID = textBoxUserName.Text;
                builder.Password = textBoxPassword.Text;
                try
                {
                    connection = new SqlConnection(builder.ConnectionString);
                    connection.Open();
                    string queries = File.ReadAllText(path2sqlCreate); 
                    string[] queryArrayCreate = Regex.Split(queries, @"\bGO\b", RegexOptions.IgnoreCase);
                    foreach (string query in queryArrayCreate)
                    {
                        if (!string.IsNullOrWhiteSpace(query))
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }
                    }
                    SqlCommand flag = new SqlCommand("SELECT COUNT(*) FROM staff", connection);
                    int count = Convert.ToInt32(flag.ExecuteScalar());
                    if (count == 0)
                    {
                        queries = File.ReadAllText(path2sqlInsert);
                        string[] queryArrayInsert = Regex.Split(queries, @"\bGO\b", RegexOptions.IgnoreCase);
                        foreach (string query in queryArrayInsert)
                        {
                            if (!string.IsNullOrWhiteSpace(query))
                            {
                                SqlCommand command = new SqlCommand(query, connection);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    this.Text = "Подключено к БД";
                    fill_DataGrid("paper", dataGridViewPaper);
                    fill_DataGrid("writing_accessories", dataGridViewWriting);
                    fill_DataGrid("USB_flash_drive", dataGridViewUSB);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
                }
            }
            else if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                this.Text = "Отключено от БД";
            }
        }

        private void fill_DataGrid(string _tamebleName, DataGridView dataGridView)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand($"SELECT * FROM {_tamebleName}", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Height = 133;
            dataGridView.DataSource = data;
        }

        private void dataGridViewPaper_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            update(sender, e, dataGridViewPaper, "paper");
        }

        private void dataGridViewWriting_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            update(sender, e, dataGridViewWriting, "writing_accessories");

        }

        private void dataGridViewUSB_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            update(sender, e, dataGridViewUSB, "USB_flash_drive");
        }

        private void update(object sender, DataGridViewCellEventArgs e, DataGridView _dataGridViewName, string _tablename)
        {
            _dataGridViewName.Columns[$"id_{_tablename}"].ReadOnly = true;
            _dataGridViewName.Columns[$"{_tablename}_name"].ReadOnly = true;
            _dataGridViewName.Columns["article_number"].ReadOnly = true;
            _dataGridViewName.Columns["price"].ReadOnly = true;
            DataGridViewCell cell = _dataGridViewName.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string newValue = cell.Value.ToString();
            DataGridViewCell idCell = _dataGridViewName.Rows[e.RowIndex].Cells[0];
            int id = Convert.ToInt32(idCell.Value);
            string updateQuery = $"UPDATE {_tablename} SET quantity_in_storage = @newValue WHERE id_{_tablename} = @id";
            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@newValue", newValue);
            updateCommand.Parameters.AddWithValue("@id", id);
            updateCommand.ExecuteNonQuery();
        }

        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            // Не понимаю, по логике форма должна закрываться если существует, а они всё равно плодятся
            Form childForm = new Form(); ;
            if (childForm != null || !childForm.IsDisposed)
            {
                childForm.Close();
            }
            childForm = new Form();
            childForm.MaximumSize = new Size(816, 300);
            childForm.MinimumSize = new Size(816, 400);
            childForm.StartPosition = FormStartPosition.CenterScreen;

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM report_quantity_goods", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataGridView dataGridView = new DataGridView();
            dataGridView.Size = new Size(776, 340);
            dataGridView.Location = new Point(10, 10);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = table;
            dataGridView.ReadOnly = true;
            childForm.Controls.Add(dataGridView);
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Этот кусок кода упорно не хотел работать, на форме Label отображался прямоугольной дырой
            //Form loadingForm = new Form();
            //loadingForm.FormBorderStyle = FormBorderStyle.None;
            //loadingForm.Size = new Size(240, 120);
            //loadingForm.StartPosition = FormStartPosition.CenterScreen;

            //Label label = new Label();
            //label.Location = new Point(20, 50);
            //label.Size = new Size(200, 20);
            //label.Text = "Загрузка серверов.....";

            //loadingForm.Controls.Add(label);
            //loadingForm.Show();

            MessageBox.Show("Закройте это окно и наберитесь терпения,\nидёт загрузка серверов.");
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();
            foreach (DataRow row in table.Rows)
            {
                comboBoxServer.Items.Add(row["ServerName"] + "\\" + row["InstanceName"].ToString());
            }
            //loadingForm.Hide();
        }
    }
}
