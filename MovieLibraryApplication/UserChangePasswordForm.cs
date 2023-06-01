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

namespace MovieLibraryApplication
{
    public partial class UserChangePasswordForm : Form
    {
        public UserChangePasswordForm()
        {
            InitializeComponent();
        }
        SqlConnection connectionsql = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MovieLibraryApplication;Integrated Security=True");
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (New_Password_textbox.UseSystemPasswordChar)
            {
                New_Password_textbox.UseSystemPasswordChar = false; // Show the text
                checkBox2.Text = "Hide"; // Change the button text
            }
            else
            {
                New_Password_textbox.UseSystemPasswordChar = true; // Hide the text
                checkBox2.Text = "Show"; // Change the button text
            }
        }

        private void UserChangePasswordForm_Load(object sender, EventArgs e)
        {
            Password_textBox.UseSystemPasswordChar = true;
            New_Password_textbox.UseSystemPasswordChar = true;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            connectionsql.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM UsersTable WHERE username = @Username AND password = @Password", connectionsql);
            sqlCommand.Parameters.AddWithValue("@Username", Username_textBox.Text);
            sqlCommand.Parameters.AddWithValue("@Password", Password_textBox.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                string username = Username_textBox.Text;
                string newPassword = New_Password_textbox.Text;
                string query = "UPDATE UsersTable SET password = @NewPassword WHERE username = @Username";
                SqlCommand command = new SqlCommand(query, connectionsql);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@Username", username);
                command.ExecuteNonQuery();
                connectionsql.Close();
                MessageBox.Show("Changed!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is wrong!");
                connectionsql.Close();
            }
        }
    }
}
