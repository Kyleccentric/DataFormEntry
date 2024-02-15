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


namespace DataEntryForm
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=Form_db;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, password;

            username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM Login WHERE username ='" + txt_username.Text + "' AND password ='" + txt_password.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, connect);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    password = txt_password.Text;

                    main mainForm = new main();
                    mainForm.Show();
                    this.Hide();
                }
                
                else
                {
                    MessageBox.Show("Invalid Login Credentials", "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
