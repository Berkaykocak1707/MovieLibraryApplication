using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieLibraryApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connectionsql = SqlConnectionClass.GetSqlConnection();
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            Password_textBox.UseSystemPasswordChar = true;
        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Username_textBox.Text == "" || Password_textBox.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
            }
            else if (Username_textBox.Text == "Admin")
            {
                connectionsql.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM UsersTable WHERE username = @P1 AND password = @P2", connectionsql);
                sqlCommand.Parameters.AddWithValue("@P1", Username_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@P2", Password_textBox.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Successful!");
                    reader.Close();
                    connectionsql.Close();
                    AdminPanelForm adminPanelForm = new AdminPanelForm();
                    adminPanelForm.Show();
                }
                else
                {
                    MessageBox.Show("No such user found! Check the username and password, sign up again if you are not a member.");
                    reader.Close();
                    connectionsql.Close();
                }
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommand2 = new SqlCommand("SELECT * FROM UsersTable WHERE username = @P1 AND password = @P2", connectionsql);
                sqlCommand2.Parameters.AddWithValue("@P1", Username_textBox.Text);
                sqlCommand2.Parameters.AddWithValue("@P2", Password_textBox.Text);
                SqlDataReader reader2 = sqlCommand2.ExecuteReader();
                if (reader2.Read())
                {
                    MessageBox.Show("Successful!");
                    reader2.Close();
                    SqlCommand sqlCommandUserId = new SqlCommand("SELECT user_id FROM Users WHERE username = @kullanici_adi;", connectionsql);
                    sqlCommandUserId.Parameters.AddWithValue("@kullanici_adi", Username_textBox.Text);
                    SqlDataReader readeruserid = sqlCommand2.ExecuteReader();
                    MovieLibraryForm LogiForm = new MovieLibraryForm();

                    while (readeruserid.Read())
                    {
                        int column1Value = readeruserid.GetInt32(0);
                        LogiForm.Userid = column1Value;

                    }
                    connectionsql.Close();
                    LogiForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No such user found! Check the username and password, sign up again if you are not a member.");
                    reader2.Close();
                    connectionsql.Close();
                }
            }
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            if (Username_textBox.Text == "" || Password_textBox.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommanduser = new SqlCommand("SELECT * FROM UsersTable WHERE username = @P1", connectionsql);
                sqlCommanduser.Parameters.AddWithValue("@P1", Username_textBox.Text);
                SqlDataReader reader = sqlCommanduser.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Username is already in use.");
                    reader.Close();
                    connectionsql.Close();
                }
                else
                {

                    reader.Close();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO UsersTable (username, password) VALUES(@P1, @P2);", connectionsql);
                    sqlCommand.Parameters.AddWithValue("@P1", Username_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", Password_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Successful!");
                    connectionsql.Close();
                }
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Password_textBox.UseSystemPasswordChar)
            {
                Password_textBox.UseSystemPasswordChar = false; // Show the text
                checkBox1.Text = "Hide"; // Change the button text
            }
            else
            {
                Password_textBox.UseSystemPasswordChar = true; // Hide the text
                checkBox1.Text = "Show"; // Change the button text
            }
        }
    }
}
