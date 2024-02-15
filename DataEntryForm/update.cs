using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DataEntryForm
{
    public partial class update : Form
    {
        private List<string> addressesList = new List<string>();
        public update(int id, string firstName, string middleName, string lastName, string address, DateTime birthday)
        {
            InitializeComponent();
            date_birthday.MaxDate = DateTime.Today;
            date_birthday.ValueChanged += Date_birthday_ValueChanged;

            txt_firstname.Text = firstName;
            txt_middlename.Text = middleName;
            txt_lastname.Text = lastName;
            date_birthday.Value = birthday;
            txt_id.Text = id.ToString();

            string[] addresses = address.Split(',');
            foreach (string addr in addresses)
            {
                listbox_address.Items.Add(addr.Trim());
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_update_click(object sender, EventArgs e)
        {
            string firstName = txt_firstname.Text;
            string middleName = txt_middlename.Text;
            string lastName = txt_lastname.Text;
            string address = txt_address.Text;
            DateTime birthday = date_birthday.Value;
            int id = Convert.ToInt32(txt_id.Text);
            PerformUpdate(firstName, middleName, lastName, address, birthday, id);

        }

        private void PerformUpdate(string firstName, string middleName, string lastName , string address ,  DateTime birthday, int id)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PC\SQLEXPRESS; Initial Catalog=Form_db; Integrated Security=True");

            conn.Open();

            string query = "UPDATE DataForm SET FirstName = '" + firstName + "', MiddleName = '" + middleName + "', LastName = '" + lastName + "', Birthday = '" + birthday + "' WHERE ID = " + id;

            try
            {
                SqlCommand command = new SqlCommand(query, conn);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("No rows were updated.");
                }


                string deleteQuery = "DELETE FROM AddressTable WHERE DataFormID = " + id;
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn);
                deleteCommand.ExecuteNonQuery();

           
                foreach (string addr in addressesList)
                {
                    string insertAddressQuery = "INSERT INTO AddressTable (DataFormID, Address) VALUES (" + id + ", '" + addr + "')";
                    SqlCommand insertAddressCommand = new SqlCommand(insertAddressQuery, conn);
                    insertAddressCommand.ExecuteNonQuery();
                       
                }
                        MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred while updating the record: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }



        }

        private void button_addAddress_Click(object sender, EventArgs e)
        {
            string Address = txt_address.Text;
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
