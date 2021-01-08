using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class Bookadministration : Form
    {
        private BookController Controller { get; }
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable { Locale = System.Globalization.CultureInfo.InvariantCulture };
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Librators.mdf;Integrated Security=True";
        public Bookadministration(BookController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            createTable();
            GetData();
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
            dataAdapter = new SqlDataAdapter("SELECT * FROM Books", connectionString);
            dataAdapter.Fill(table);
            addButton("Reservieren");
            addButton("Ausleihe");
            addButton("Rückgabe");
            if (CurrentUser.getAdmin())
            {
                addButton("Löschen");
                addButton("Bearbeiten");
            } else
            {
                btnAdd.Hide();
                button2.Hide();
            }
            table.Columns.Add("_RowString", typeof(string));
            dataGridView1.Columns["_RowString"].Visible = false;
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
        private void GetData()
        {
            try
            {
                table.Clear();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Books", connectionString);
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
                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Keine Einträge vorhanden! " + sql.Message);
            }
        }
        private int HeaderPosition(string value)
        {
            return dataGridView1.Columns[value].Index;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string inventoryNumber = dataGridView1.Rows[e.RowIndex].Cells[HeaderPosition("Inventar_Number")].Value.ToString();
            string iSBN = dataGridView1.Rows[e.RowIndex].Cells[HeaderPosition("ISBN")].Value.ToString();
            
            if (e.ColumnIndex == HeaderPosition("Reservieren"))
            {
                Controller.ReserveBook(iSBN, inventoryNumber);
            }
           
            if (e.ColumnIndex == HeaderPosition("Rückgabe"))
            {
                Controller.ReturnBook(iSBN, inventoryNumber);
            }
            if (e.ColumnIndex == HeaderPosition("Ausleihe"))
            {
                Controller.LendBook(iSBN, inventoryNumber);
            }
            if (CurrentUser.getAdmin())
            {
                if (e.ColumnIndex == HeaderPosition("Löschen"))
                {
                    Controller.Delete(iSBN, inventoryNumber);
                }
                if (e.ColumnIndex == HeaderPosition("Bearbeiten"))
                {
                    Controller.ShowBookInformation(iSBN, inventoryNumber);
                }
            }
            RefreshData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Controller.Back();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetData();
            if (textBox1.Text != "Suche") table.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);
        }
        private void textBox1_Clicked(object sender, EventArgs e)
        {
            if (textBox1.Text == "Suche") textBox1.Text = "";
        }
        public void RefreshData()
        {
            GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.Add();
        }
    } 
}