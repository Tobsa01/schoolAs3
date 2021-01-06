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
    public partial class Useradministration : Form
    {
        private UserController Controller { get; }

        private UserModel Model { get; }

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable {Locale = System.Globalization.CultureInfo.InvariantCulture};
        private bool first_load = true;


        public Useradministration(UserController controller)
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

              
                String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Librators.mdf;Integrated Security=True";
              
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;


                // Add additional column for filtering 
                if (first_load) 
                { 
                    DataColumn dcRowString = table.Columns.Add("_RowString", typeof(string)); //System.Data.DuplicateNameException
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

                // Resize the DataGridView columns to fit the newly loaded content

                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("User wurde nicht gefunden");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bind the DataGridView to the BindingSource and load the data from the database
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Users");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SucheNutzer();
        }

        private void SucheNutzer()
        {
            dataGridView1.DataSource = bindingSource1;
            String text = "SELECT * FROM Users Where FirstName LIKE '" + textBox1.Text + "%'  OR LastName LIKE '" + textBox1.Text + "%' OR  MANumber ='" + textBox1.Text + "'";
            GetData(text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.Back();
        }

        private void button3_Click(object sender, EventArgs e)
        {

                Controller.Add();
            
        }

        // Filter triggern
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            table.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);
        }
    }
}
