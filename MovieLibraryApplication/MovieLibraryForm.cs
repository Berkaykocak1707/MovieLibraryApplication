﻿using System;
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
    public partial class MovieLibraryForm : Form
    {
        public MovieLibraryForm()
        {
            InitializeComponent();
        }
        SqlConnection connectionsql = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MovieLibraryApplication;Integrated Security=True");
        private void MovieLibraryForm_Load(object sender, EventArgs e)
        { 
            GetTable();
        }
        private int UserID;
        public int Userid
        {
            get
            {
                return UserID;
            }
            set
            {
                UserID = value;
            }
        }
        public void GetTable()
        {
            connectionsql.Open();
            SqlDataAdapter MovieCommand = new SqlDataAdapter("SELECT * FROM MoviesTable WHERE User_ID = "+ Userid, connectionsql);
            
            DataTable MovieTable = new DataTable();
            MovieCommand.Fill(MovieTable);
            idlbl.Text = Userid.ToString();
            dataGridView1.DataSource = MovieTable;
            connectionsql.Close();
        }
        public void datagridupdate()
        {
            Title_textBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Director_textBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Cast_textBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Genre_textBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Release_Year_textBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Rating_textBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Description_textBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            MovieID_Label.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            datagridupdate();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (Title_textBox.Text ==""|| Director_textBox.Text == "" || Cast_textBox.Text == "" || Genre_textBox.Text == "" ||Release_Year_textBox.Text == "" ||Rating_textBox.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
                twronglabel.Visible = true;
                dwronglabel.Visible = true;
                cwronglabel.Visible = true;
                gwronglabel.Visible = true;
                dwronglabel.Visible = true;
                rwronglabel.Visible = true;
                rrwronglabel.Visible = true;
            }
            else if (Convert.ToInt32(Rating_textBox.Text) > 5 || Convert.ToInt32(Rating_textBox.Text) < 0)
            {
                MessageBox.Show("Rating must be between 0-5.");
            }
            else if (Convert.ToInt32(Release_Year_textBox.Text) < 1896)
            {
                MessageBox.Show("The first movie in history was in 1896.");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO MoviesTable (user_ID,title, director, cast, genre, release_year, rating, description) VALUES(" + Userid + ",@title, @director, @cast, @genre, @release_year, @rating, @description);", connectionsql);
                sqlCommand.Parameters.AddWithValue("@title", Title_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@director", Director_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@cast", Cast_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@genre", Genre_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@release_year", Release_Year_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@rating", Rating_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@description", Description_textBox.Text);
                sqlCommand.ExecuteNonQuery();
                connectionsql.Close();
                GetTable();
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (Title_textBox.Text == "" || Director_textBox.Text == "" || Cast_textBox.Text == "" || Genre_textBox.Text == "" || Release_Year_textBox.Text == "" || Rating_textBox.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
                twronglabel.Visible = true;
                dwronglabel.Visible = true;
                cwronglabel.Visible = true;
                gwronglabel.Visible = true;
                dwronglabel.Visible = true;
                rwronglabel.Visible = true;
                rrwronglabel.Visible = true;
            }
            else if (Convert.ToInt32(Rating_textBox.Text) > 5 || Convert.ToInt32(Rating_textBox.Text) < 0)
            {
                MessageBox.Show("Rating must be between 0-5.");
            }
            else if(Convert.ToInt32(Release_Year_textBox.Text) < 1896)
            {
                MessageBox.Show("The first movie in history was in 1896.");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE MoviesTable SET user_ID = " + Userid + ", title = @title, director = @director, cast = @cast, genre = @genre, release_year = @release_year, rating = @rating, description = @description WHERE movie_ID = @ID;", connectionsql);
                sqlCommand.Parameters.AddWithValue("@title", Title_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@director", Director_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@cast", Cast_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@genre", Genre_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@release_year", Convert.ToInt32(Release_Year_textBox.Text));
                sqlCommand.Parameters.AddWithValue("@rating", Convert.ToInt32(Rating_textBox.Text));
                sqlCommand.Parameters.AddWithValue("@description", Description_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(MovieID_Label.Text));
                sqlCommand.ExecuteNonQuery();
                connectionsql.Close();
                GetTable();
            }
        }
        

        private void Delete_button_Click(object sender, EventArgs e)
        {
            connectionsql.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM MoviesTable WHERE movie_ID = @ID;", connectionsql);
            sqlCommand.Parameters.AddWithValue("@ID",Convert.ToInt32(MovieID_Label.Text));
            sqlCommand.ExecuteNonQuery();
            connectionsql.Close();
            GetTable();
        }

        private void Change_Password_button_Click(object sender, EventArgs e)
        {
            UserChangePasswordForm form = new UserChangePasswordForm();
            form.Show();
        }
    }
}
