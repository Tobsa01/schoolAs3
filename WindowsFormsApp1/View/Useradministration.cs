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
        private WindowsFormsApp1.Model.UserModel Model { get; }

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

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
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
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
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
    }
}
