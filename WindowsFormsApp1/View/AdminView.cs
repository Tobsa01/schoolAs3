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
    public partial class Library_Admin : Form
    {
        private AdminController Controller { get; }
        private WindowsFormsApp1.Model.AdminModel Model { get; }
        DataTable table = new DataTable { Locale = System.Globalization.CultureInfo.InvariantCulture };
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Library_Admin(AdminController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
            Model = Controller.Model;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Controller.Buecher();
        }

        public void HideForm()
        {
            Hide();
        }

        public void ShowForm()
        {
            Show();
        }

        public void LoadForm()
        {
            InitializeComponent();
        }

        private void AdminView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.CloseProgram();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Buecher();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Controller.User();
        }
       
        private void GetData(string selectCommand, DataGridView dgv, BindingSource bs)
        {
            try
            {
                String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Librators.mdf;Integrated Security=True";
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(table);
                bs.DataSource = table;
                dgv.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (SqlException)
            {
                MessageBox.Show("Aktuell sind keine Bücher ausgeliehen.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Issues;", dataGridView1, bindingSource1);
            dataGridView2.DataSource = bindingSource2;
            GetData("select * from Reservations;", dataGridView2, bindingSource2);
        }


    }
}
