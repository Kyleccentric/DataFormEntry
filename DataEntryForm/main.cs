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
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace DataEntryForm
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            DataFormTable.DataSource = new DataTable();
            LoadData();
            DataFormTable.CellClick += DataFormTable_CellClick;
        }
        SqlConnection connect = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=Form_db;Integrated Security=True");
        private int clickedRowID = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            insert insertForm = new insert();
            insertForm.FormClosed += InsertForm_FormClosed;
            insertForm.Show();
            connect.Close();
        }

        private void LoadData()
        {
            try
            {
                connect.Open();
                string query = @"SELECT df.ID, df.FirstName, df.MiddleName, df.LastName, df.Age, df.Birthday, 
                        STUFF((SELECT ', ' + Address
                               FROM AddressTable 
                               WHERE DataFormID = df.ID 
                               FOR XML PATH('')), 1, 2, '') AS Address
                        FROM DataForm df";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataFormTable.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void InsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }


        private void button_update_Click(object sender, EventArgs e)
        {

            if (DataFormTable.SelectedRows.Count > 0)
            {
                OpenUpdateForm(DataFormTable.SelectedRows[0]);
            }
            else if (DataFormTable.CurrentCell != null)
            {
                int rowIndex = DataFormTable.CurrentCell.RowIndex;
                OpenUpdateForm(DataFormTable.Rows[rowIndex]);
            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }
        }
        private void OpenUpdateForm(DataGridViewRow row)
        {
            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string firstName = row.Cells["FirstName"].Value.ToString();
            string middleName = row.Cells["MiddleName"].Value.ToString();
            string lastName = row.Cells["LastName"].Value.ToString();
            string address = row.Cells["Address"].Value.ToString();
            DateTime birthday = Convert.ToDateTime(row.Cells["Birthday"].Value);

            update updateForm = new update(id, firstName, middleName, lastName, address, birthday);
            updateForm.FormClosed += UpdateForm_FormClosed;
            updateForm.Show();
            connect.Close();
        }
        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (clickedRowID != -1)
            {
                DialogResult result = MessageBox.Show("\"Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        if (connect.State == ConnectionState.Open)
                        {
                            connect.Close();
                        }

                        connect.Open();
                        string query = "DELETE FROM DataForm WHERE ID =" + clickedRowID;
                        SqlCommand command = new SqlCommand(query, connect);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                        {
                            connect.Close();
                        }
                        LoadData();
                        clickedRowID = -1;
                    }
                }
            }
        }
        private void DataFormTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clickedRowID = Convert.ToInt32(DataFormTable.Rows[e.RowIndex].Cells["ID"].Value);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchQuery = txt_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                DataTable dataTable = (DataTable)DataFormTable.DataSource;

                if (dataTable != null)
                {
                    DataTable filteredDataTable = dataTable.Clone();

                    foreach (DataRow row in dataTable.Rows)
                    {

                        if (row["ID"].ToString().Contains(searchQuery) ||
                            row["FirstName"].ToString().Contains(searchQuery) ||
                            row["MiddleName"].ToString().Contains(searchQuery) ||
                            row["LastName"].ToString().Contains(searchQuery) ||
                            row["Address"].ToString().Contains(searchQuery) ||
                            row["Age"].ToString().Contains(searchQuery) ||
                            ((DateTime)row["Birthday"]).ToString("yyyy-MM-dd").Contains(searchQuery))
                        {
                            filteredDataTable.ImportRow(row);
                        }
                    }

                    DataFormTable.DataSource = filteredDataTable;
                }
            }
            else
            {
                LoadData();
            }
            connect.Close();
        }

        private void ExportToCSV()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FilterIndex = 0,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvContent = new StringBuilder();

                // Add headers
                for (int i = 0; i < DataFormTable.Columns.Count; i++)
                {
                    csvContent.Append(DataFormTable.Columns[i].HeaderText);
                    if (i < DataFormTable.Columns.Count - 1)
                    {
                        csvContent.Append(",");
                    }
                }
                csvContent.AppendLine();

                // Add rows
                foreach (DataGridViewRow row in DataFormTable.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        string value = row.Cells[i].Value?.ToString();
                        if (i == 5 && !string.IsNullOrEmpty(value)) // Birthday column is the 6th column
                        {
                            value = ((DateTime)row.Cells[i].Value).ToString("dd/MM/yyyy"); // Format as date only
                        }
                        csvContent.Append(value);
                        if (i < row.Cells.Count - 1)
                        {
                            csvContent.Append(",");
                        }
                    }
                    csvContent.AppendLine();
                }

                // Write to file
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(csvContent.ToString());
                }
            }
        }

        private void button_report_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }


    }
}