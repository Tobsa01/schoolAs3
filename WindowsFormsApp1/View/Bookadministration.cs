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
        private bool first_load = true;
        private int positionDelete;
        private int positionReserve;
        private int positionIssue;
        private int positionReturn;

        private int positionUpdate;

        public Bookadministration(BookController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
            Model = Controller.Model;
        }
        public void HideForm()
        {
            Hide();
        }

        public void ShowForm()
        {
            Show();
        }


        private void GetData(string selectCommand)
        {
            try
            {
                table.Clear();
                String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Librators.mdf;Integrated Security=True";
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                // Add additional column for filtering 
                if (first_load)
                {
                    DataColumn dcRowString = table.Columns.Add("_RowString", typeof(string));
                    // build filter string
                    foreach (DataRow dataRow in table.Rows)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < table.Columns.Count - 1; i++)
                        {
                            sb.Append(dataRow[i].ToString());
                            sb.Append("\t");
                        }
                        dataRow[dcRowString] = sb.ToString();
                    }
                    first_load = false;
                }

                
                // Hide filter string column
                dataGridView1.Columns["_RowString"].Visible = false;
                
                addButton("Löschen", ref positionDelete);
                addButton("Reservieren", ref positionReserve);
                addButton("Ausleihe", ref positionIssue);
                addButton("Rückgabe", ref positionReturn);
                addButton("Bearbeiten", ref positionUpdate);

                // Resize the DataGridView columns to fit the newly loaded content.

                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);
                dataAdapter.Update((DataTable)bindingSource1.DataSource);
                // dataGridView1.CellClick += dataGridView1_CellClick;

            }
            catch (SqlException sql)
            {
                MessageBox.Show("Keine Einträge vorhanden! " + sql.Message);
            }
        }
        private void addButton(string buttonName, ref int place)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = buttonName;
            button.Text = buttonName;
            if (dataGridView1.Columns[buttonName] == null)
            {
                dataGridView1.Columns.Add(button);
                place = dataGridView1.Columns.Count - 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Books");
        }
        private void SucheBuch()
        {
            dataGridView1.DataSource = bindingSource1;
            String text = "SELECT * FROM Books Where Author LIKE '%" + textBox1.Text + "%'  OR ISBN ='" + textBox1.Text + "' OR  Title LIKE '%" + textBox1.Text + "%'";
            GetData(text);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SucheBuch();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            string inventoryNumber = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string iSBN = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (e.ColumnIndex == positionDelete)
            {
                Controller.Delete(iSBN, inventoryNumber);
            }
            if (e.ColumnIndex == positionReserve)
            {
                Controller.ReserveBook(iSBN, inventoryNumber);
            }
            if (e.ColumnIndex == positionIssue)
            {
                Controller.LendBook(iSBN, inventoryNumber);
            }
            if (e.ColumnIndex == positionReturn)
            {
                Controller.ReturnBook(iSBN, inventoryNumber);
            }
            if (e.ColumnIndex == positionUpdate)
            {
                Controller.ShowBookInformation(iSBN, inventoryNumber);
            }
             
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.Back();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                table.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);
            }

        }
        public void RefreshData()
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Books");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }
    } 
}