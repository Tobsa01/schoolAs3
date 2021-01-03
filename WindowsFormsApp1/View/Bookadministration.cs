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
                    DataGridViewAutoSizeColumnsMode.AllCells);
                dataAdapter.Update((DataTable)bindingSource1.DataSource);

            }
            catch (SqlException sql)
            {
                MessageBox.Show("Keine Einträge vorhanden! " + sql.Message);
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
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            String inv = row.Cells[0].Value.ToString();

            GetData("INSERT INTO Reservations (FK_ISBN, FK_Inventar_Number, FK_UserID, FK_MANumber, ReservationDate) " +
                "Values ((SELECT ISBN FROM Books Where Inventar_Number= '"+ inv +"'), '"+ inv +
                "', 1, 1234, CURRENT_TIMESTAMP)");

            dataAdapter.Update((DataTable)bindingSource1.DataSource);

            GetData("INSERT INTO Issues (FK_ISBN, FK_Inventar_Number, FK_UserID, FK_MANumber, ReturnDate, StartDate, IssueState) " +
                "Values ((SELECT ISBN FROM Books Where Inventar_Number= '" + inv + "'), '" + inv +
                "', 1, 1234, DATEADD(month, 1, CURRENT_TIMESTAMP), CURRENT_TIMESTAMP, 'aus')");
            dataAdapter.Update((DataTable)bindingSource1.DataSource);

            GetData("SELECT * FROM Reservations");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.Back();
        }
    }
}