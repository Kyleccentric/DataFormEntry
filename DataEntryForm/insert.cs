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
using System.Net;

namespace DataEntryForm
{   


    public partial class insert : Form
    {
        private List<string> addressesList = new List<string>();
        public insert()
        {
            InitializeComponent();
            date_birthday.MaxDate = DateTime.Today;
            date_birthday.ValueChanged += Date_birthday_ValueChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Date_birthday_ValueChanged(object sender, EventArgs e)
        {

            CalculateAge();
        }


        private void txt_age_TextChanged(object sender, EventArgs e)
        {
            CalculateAge();
        }

        private void CalculateAge()
        {
            DateTime dob = date_birthday.Value;

            int age = DateTime.Today.Year - dob.Year;

            if (DateTime.Today < dob.AddYears(age))
            {
                age--;
            }

            txt_age.Text = age.ToString();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string firstName = txt_firstname.Text;
            string middleName = txt_middlename.Text;
            string lastName = txt_lastname.Text;
            
            DateTime dob = date_birthday.Value;
            int age = Convert.ToInt32(txt_age.Text);

            string address = string.Join(", ", addressesList);

            SqlConnection conn= new SqlConnection(@"Data Source=PC\SQLEXPRESS; Initial Catalog=Form_db; Integrated Security=True");  
            try
            {
                conn.Open();

                string query = "INSERT INTO DataForm (FirstName,MiddleName,LastName,Age,Birthday) VALUES ('"+firstName+ "', '"+middleName+ "', '"+lastName+"','"+age+"', '"+dob.ToString("MM-dd-yy")+ "' )";
                
                SqlCommand insertDataFormCommand = new SqlCommand(query + "; SELECT SCOPE_IDENTITY();", conn);
                object dataFormIDObject = insertDataFormCommand.ExecuteScalar();

                int dataFormID = dataFormIDObject != null ? Convert.ToInt32(dataFormIDObject) : -1;
                foreach (string addr in addressesList)
                {
                    string insertAddressQuery = "INSERT INTO AddressTable (DataFormID, Address) VALUES (" + dataFormID + ", '" + addr + "')";
                    SqlCommand insertAddressCommand = new SqlCommand(insertAddressQuery, conn);
                    insertAddressCommand.ExecuteNonQuery();
                }

                if (dataFormID != -1)
                {
                    MessageBox.Show("Data Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to Insert Data");
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        private void insert_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_addAddress_Click(object sender, EventArgs e)
        {
            string Address = txt_address.Text ;
            listbox_address.Items.Add(Address);
            addressesList.Add(Address);
        }

        private void button_deleteAddress_Click(object sender, EventArgs e)
        {
            if (listbox_address.SelectedIndex != -1)
            {  
                listbox_address.Items.RemoveAt(listbox_address.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an address to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
