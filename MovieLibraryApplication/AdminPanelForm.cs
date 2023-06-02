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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }
        SqlConnection connectionsql = SqlConnectionClass.GetSqlConnection();

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            GetTableUser();
            GetTableMovie();
        }
        public void GetTableUser()
        {
            connectionsql.Open();
            SqlDataAdapter UserCommand = new SqlDataAdapter("SELECT * FROM UsersTable", connectionsql);

            DataTable UserTable = new DataTable();
            UserCommand.Fill(UserTable);
            UserdataGridView_Admin.DataSource = UserTable;
            connectionsql.Close();
        }
        public void GetTableMovie()
        {
            connectionsql.Open();
            SqlDataAdapter MovieCommand = new SqlDataAdapter("SELECT * FROM MoviesTable", connectionsql);

            DataTable MovieTable = new DataTable();
            MovieCommand.Fill(MovieTable);
            MoviedataGridView_Admin.DataSource = MovieTable;
            connectionsql.Close();
        }
        public void datagridupdateuser()
        {
            Username_textBox_Admin.Text = UserdataGridView_Admin.CurrentRow.Cells[1].Value.ToString();
            Password_textBox_Admin.Text = UserdataGridView_Admin.CurrentRow.Cells[2].Value.ToString();
            UserID_User_Label_Admin.Text = UserdataGridView_Admin.CurrentRow.Cells[0].Value.ToString();
        }
        public void datagridupdatemovie()
        {
            Title_textBox_Admin.Text = MoviedataGridView_Admin.CurrentRow.Cells[2].Value.ToString();
            Director_textBox_Admin.Text = MoviedataGridView_Admin.CurrentRow.Cells[3].Value.ToString();
            Cast_textBox_Admin.Text = MoviedataGridView_Admin.CurrentRow.Cells[4].Value.ToString();
            Genre_textBox_Admin.Text = MoviedataGridView_Admin.CurrentRow.Cells[5].Value.ToString();
            Release_Year_textBox_Admin.Text = MoviedataGridView_Admin.CurrentRow.Cells[6].Value.ToString();
            Rating_textBox_Admin.Text = MoviedataGridView_Admin.CurrentRow.Cells[7].Value.ToString();
            Description_textBox_Admin.Text = MoviedataGridView_Admin.CurrentRow.Cells[8].Value.ToString();
            UserID_Movie_textBox_Admin.Text = MoviedataGridView_Admin.CurrentRow.Cells[1].Value.ToString();
            MovieID_Label_Admin.Text = MoviedataGridView_Admin.CurrentRow.Cells[0].Value.ToString();
        }
        private void Add_button_Click_Admin(object sender, EventArgs e)
        {
            if (Username_textBox_Admin.Text == "" || Password_textBox_Admin.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
                uwronglabel.Visible = true;
                pwronglabel.Visible = true;
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommanduser = new SqlCommand("SELECT * FROM UsersTable WHERE username = @P1", connectionsql);
                sqlCommanduser.Parameters.AddWithValue("@P1", Username_textBox_Admin.Text);
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
                    sqlCommand.Parameters.AddWithValue("@P1", Username_textBox_Admin.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", Password_textBox_Admin.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Successful!");
                    connectionsql.Close();
                    GetTableUser();
                }
            }
        }

        private void MoviedataGridView_Admin_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            datagridupdatemovie();
        }

        private void UserdataGridView_Admin_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            datagridupdateuser();
        }

        private void Delete_User_button_Admin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(UserID_User_Label_Admin.Text) == 1)
            {
                MessageBox.Show("You can't delete the Admin");
            }
            else
            {
                connectionsql.Open();
                int userID = Convert.ToInt32(UserID_User_Label_Admin.Text);
                SqlCommand sqlCommandMovie = new SqlCommand("DELETE FROM MoviesTable WHERE user_ID = @ID;", connectionsql);
                sqlCommandMovie.Parameters.AddWithValue("@ID", userID);
                sqlCommandMovie.ExecuteNonQuery();
                string query = "DELETE FROM UsersTable WHERE user_ID = @UserID";
                SqlCommand sqlCommand = new SqlCommand(query, connectionsql);
                sqlCommand.Parameters.AddWithValue("@UserID", userID);
                sqlCommand.ExecuteNonQuery();
                connectionsql.Close();
                GetTableUser();
                GetTableMovie();
            }
        }

        private void Update_User_button_Admin_Click(object sender, EventArgs e)
        {
            if (Username_textBox_Admin.Text == "" || Password_textBox_Admin.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
                uwronglabel.Visible = true;
                pwronglabel.Visible = true;
            }
            else
            {
                connectionsql.Open();

                int userID = Convert.ToInt32(UserID_User_Label_Admin.Text);
                string newUsername = Username_textBox_Admin.Text;
                string newPassword = Password_textBox_Admin.Text;

                string query = "UPDATE UsersTable SET username = @NewUsername, password = @NewPassword WHERE user_ID = @UserID";
                SqlCommand sqlCommand = new SqlCommand(query, connectionsql);
                sqlCommand.Parameters.AddWithValue("@NewUsername", newUsername);
                sqlCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                sqlCommand.Parameters.AddWithValue("@UserID", userID);
                sqlCommand.ExecuteNonQuery();
                connectionsql.Close();
                GetTableUser();
            }
        }

        private void Add_Movie_Button_Admin_Click(object sender, EventArgs e)
        {
            if (Title_textBox_Admin.Text == "" || Director_textBox_Admin.Text == "" || Cast_textBox_Admin.Text == "" || Genre_textBox_Admin.Text == "" || Release_Year_textBox_Admin.Text == "" || Rating_textBox_Admin.Text == ""||UserID_Movie_textBox_Admin.Text=="")
            {
                MessageBox.Show("Fill in the required fields.");
                twronglabel.Visible = true;
                usidwronglabel.Visible = true;
                dwronglabel.Visible = true;
                cwronglabel.Visible = true;
                gwronglabel.Visible = true;
                pwronglabel.Visible = true;
                rwronglabel.Visible = true;
                rrwronglabel.Visible = true;
            }
            else if (Convert.ToInt32(Rating_textBox_Admin.Text) > 5 || Convert.ToInt32(Rating_textBox_Admin.Text) < 0)
            {
                MessageBox.Show("Rating must be between 0-5.");
            }
            else if (Convert.ToInt32(Release_Year_textBox_Admin.Text) < 1896)
            {
                MessageBox.Show("The first movie in history was in 1896.");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO MoviesTable (user_ID,title, director, cast, genre, release_year, rating, description) VALUES(@user_ID,@title, @director, @cast, @genre, @release_year, @rating, @description);", connectionsql);
                sqlCommand.Parameters.AddWithValue("@title", Title_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@director", Director_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@cast", Cast_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@genre", Genre_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@release_year", Release_Year_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@rating", Rating_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@description", Description_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@user_ID", UserID_Movie_textBox_Admin.Text);
                sqlCommand.ExecuteNonQuery();
                connectionsql.Close();
                GetTableMovie();
            }
        }

        private void Update_Movie_button_Admin_Click(object sender, EventArgs e)
        {
            if (Title_textBox_Admin.Text == "" || Director_textBox_Admin.Text == "" || Cast_textBox_Admin.Text == "" || Genre_textBox_Admin.Text == "" || Release_Year_textBox_Admin.Text == "" || Rating_textBox_Admin.Text == "" || UserID_Movie_textBox_Admin.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
                twronglabel.Visible = true;
                usidwronglabel.Visible = true;
                dwronglabel.Visible = true;
                cwronglabel.Visible = true;
                gwronglabel.Visible = true;
                pwronglabel.Visible = true;
                rwronglabel.Visible = true;
                rrwronglabel.Visible = true;
            }
            else if (Convert.ToInt32(Rating_textBox_Admin.Text) > 5 || Convert.ToInt32(Rating_textBox_Admin.Text) < 0)
            {
                MessageBox.Show("Rating must be between 0-5.");
            }
            else if (Convert.ToInt32(Release_Year_textBox_Admin.Text) < 1896)
            {
                MessageBox.Show("The first movie in history was in 1896.");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE MoviesTable SET user_ID = @user_ID, title = @title, director = @director, cast = @cast, genre = @genre, release_year = @release_year, rating = @rating, description = @description WHERE movie_ID = @ID;", connectionsql);
                sqlCommand.Parameters.AddWithValue("@title", Title_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@director", Director_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@cast", Cast_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@genre", Genre_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@release_year", Convert.ToInt32(Release_Year_textBox_Admin.Text));
                sqlCommand.Parameters.AddWithValue("@rating", Convert.ToInt32(Rating_textBox_Admin.Text));
                sqlCommand.Parameters.AddWithValue("@description", Description_textBox_Admin.Text);
                sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(MovieID_Label_Admin.Text));
                sqlCommand.Parameters.AddWithValue("@user_ID", UserID_Movie_textBox_Admin.Text);
                sqlCommand.ExecuteNonQuery();
                connectionsql.Close();
                GetTableMovie();
            }
        }

        private void Delete_Movie_button_Admin_Click(object sender, EventArgs e)
        {
            connectionsql.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM MoviesTable WHERE movie_ID = @ID;", connectionsql);
            sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(MovieID_Label_Admin.Text));
            sqlCommand.ExecuteNonQuery();
            connectionsql.Close();
            GetTableMovie();
        }
    }
}