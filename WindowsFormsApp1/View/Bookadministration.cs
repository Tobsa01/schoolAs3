using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Bookadministration : Form
    {
        private BookController Controller { get; }
        private WindowsFormsApp1.Model.BookAdminModel Model { get; }
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable { Locale = System.Globalization.CultureInfo.InvariantCulture };

        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Librators.mdf;Integrated Security=True";



        public Bookadministration(BookController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
            Model = Controller.Model;
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            createTable();
            GetData("select * from Books");
        }
        public void HideForm()
        {
            Hide();
        }

        public void ShowForm()
        {
            Show();
        }
        private void createTable()
        {
            dataAdapter = new SqlDataAdapter("select * from Books", connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(table);
            addButton("Löschen");
            addButton("Reservieren");
            addButton("Ausleihe");
            addButton("Bearbeiten");
            table.Columns.Add("_RowString", typeof(string));
            dataGridView1.Columns["_RowString"].Visible = false;
        }
        private void GetData(string selectCommand)
        {
            try
            {
                table.Clear();
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(table);
                foreach (DataRow dataRow in table.Rows)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < table.Columns.Count - 1; i++)
                    {
                        sb.Append(dataRow[i].ToString());
                        sb.Append("\t");
                    }
                    dataRow["_RowString"] = sb.ToString();
                }

                
                // Hide filter string column
                dataGridView1.Columns["_RowString"].Visible = false;
                // Resize the DataGridView columns to fit the newly loaded content.

                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);

                dataAdapter.Update((DataTable)bindingSource1.DataSource);
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Keine Einträge vorhanden! " + sql.Message);
            }
        }
        private void addButton(string buttonName)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = buttonName;
            button.Text = buttonName;
            if (dataGridView1.Columns[buttonName] == null)
            {
                dataGridView1.Columns.Add(button);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Books");
        }
        private int HeaderPosition(string value)
        {
            return dataGridView1.Columns[value].Index;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            string inventoryNumber = dataGridView1.Rows[e.RowIndex].Cells[HeaderPosition("Inventar_Number")].Value.ToString();
            string iSBN = dataGridView1.Rows[e.RowIndex].Cells[HeaderPosition("ISBN")].Value.ToString();
            if (e.ColumnIndex == dataGridView1.Columns["Löschen"].Index)
            {
                Controller.Delete(iSBN, inventoryNumber);
            }
            if (e.ColumnIndex == dataGridView1.Columns["Reservieren"].Index)
            {
                Controller.ReserveBook(iSBN, inventoryNumber);
            }
            if (e.ColumnIndex == dataGridView1.Columns["Bearbeiten"].Index)
            {
                Controller.ShowBookInformation(iSBN, inventoryNumber);
            }

            if (e.ColumnIndex == dataGridView1.Columns["Rückgabe"].Index)
            {
                Controller.ReturnBook(iSBN, inventoryNumber);
            }
 
             if (e.ColumnIndex == dataGridView1.Columns["Ausleihe"].Index)

            {
                Controller.ShowBookInformation(iSBN, inventoryNumber);
            }
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.Back();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetData("select * from Books");
            if (textBox1.Text != "Suche") table.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);
            dataAdapter.Update((DataTable)bindingSource1.DataSource);
        }
        private void textBox1_Clicked(object sender, EventArgs e)
        {
            if (textBox1.Text == "Suche") textBox1.Text = "";
        }
        public void RefreshData()
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Books");
            if(textBox1.Text != "Suche") table.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }
    } 
}