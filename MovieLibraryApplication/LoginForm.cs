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
        SqlConnection connectionsql = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MovieLibraryApplication;Integrated Security=True");
        private void LoginForm_Load(object sender, EventArgs e)
        {
            connectionsql.Open();
            Password_textBox.UseSystemPasswordChar = true;
        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Username_textBox.Text == ""|| Password_textBox.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM UsersTable WHERE username = @P1 AND password = @P2", connectionsql);
                sqlCommand.Parameters.AddWithValue("@P1",Username_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@P2",Password_textBox.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Successful!");
                    reader.Close();
                    SqlCommand sqlCommandUserId = new SqlCommand("SELECT user_id FROM Users WHERE username = @kullanici_adi;", connectionsql);
                    sqlCommand.Parameters.AddWithValue("@kullanici_adi", Username_textBox.Text);
                    SqlDataReader readeruserid = sqlCommand.ExecuteReader();
                    MovieLibraryForm LogiForm = new MovieLibraryForm();
                    
                    while (readeruserid.Read())
                    {
                        int column1Value = readeruserid.GetInt32(0);
                        LogiForm.Userid = column1Value;
                        
                    }
                    LogiForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No such user found! Check the username and password, sign up again if you are not a member.");
                    reader.Close();
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
                SqlCommand sqlCommanduser = new SqlCommand("SELECT * FROM UsersTable WHERE username = @P1", connectionsql);
                sqlCommanduser.Parameters.AddWithValue("@P1", Username_textBox.Text);
                SqlDataReader reader = sqlCommanduser.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Username is already in use.");
                    reader.Close();
                }
                else
                {

                    reader.Close();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO UsersTable (username, password) VALUES(@P1, @P2);", connectionsql);
                    sqlCommand.Parameters.AddWithValue("@P1", Username_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", Password_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Successful!");
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
