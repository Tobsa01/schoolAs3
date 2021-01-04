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
        private BookController Controller { get;}
        private WindowsFormsApp1.Model.BookAdminModel Model { get; }
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable {Locale = System.Globalization.CultureInfo.InvariantCulture};
        private bool first_load = true;

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
                // Specify a connection string
                String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Librators.mdf;Integrated Security=True";
                // Create a new data adapter based on the specified query
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                // Create a command builder to generate SQL update, insert, and delete commands based on selectCommand
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Bind data table to the BindingSource
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

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bind the DataGridView to the BindingSource and load the data from the database
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Books");
        }

        // Filter triggern
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            table.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);
        }
    }
}
