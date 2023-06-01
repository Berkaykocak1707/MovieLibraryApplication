namespace MovieLibraryApplication
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.pwronglabel = new System.Windows.Forms.Label();
            this.uwronglabel = new System.Windows.Forms.Label();
            this.Delete_User_button_Admin = new System.Windows.Forms.Button();
            this.Update_User_button_Admin = new System.Windows.Forms.Button();
            this.Add_User_button_Admin = new System.Windows.Forms.Button();
            this.UserdataGridView_Admin = new System.Windows.Forms.DataGridView();
            this.Password_textBox_Admin = new System.Windows.Forms.TextBox();
            this.Username_textBox_Admin = new System.Windows.Forms.TextBox();
            this.Password_label_Admin = new System.Windows.Forms.Label();
            this.Username_label_Admin = new System.Windows.Forms.Label();
            this.rrwronglabel = new System.Windows.Forms.Label();
            this.rwronglabel = new System.Windows.Forms.Label();
            this.gwronglabel = new System.Windows.Forms.Label();
            this.cwronglabel = new System.Windows.Forms.Label();
            this.dwronglabel = new System.Windows.Forms.Label();
            this.twronglabel = new System.Windows.Forms.Label();
            this.Delete_Movie_button_Admin = new System.Windows.Forms.Button();
            this.Update_Movie_button_Admin = new System.Windows.Forms.Button();
            this.Add_Movie_Button_Admin = new System.Windows.Forms.Button();
            this.MoviedataGridView_Admin = new System.Windows.Forms.DataGridView();
            this.Description_textBox_Admin = new System.Windows.Forms.TextBox();
            this.Rating_textBox_Admin = new System.Windows.Forms.TextBox();
            this.Release_Year_textBox_Admin = new System.Windows.Forms.TextBox();
            this.Genre_textBox_Admin = new System.Windows.Forms.TextBox();
            this.Cast_textBox_Admin = new System.Windows.Forms.TextBox();
            this.Director_textBox_Admin = new System.Windows.Forms.TextBox();
            this.Title_textBox_Admin = new System.Windows.Forms.TextBox();
            this.Description_label_Admin = new System.Windows.Forms.Label();
            this.Rating_label_Admin = new System.Windows.Forms.Label();
            this.Genre_label_Admin = new System.Windows.Forms.Label();
            this.Release_Year_label_Admin = new System.Windows.Forms.Label();
            this.Director_label_Admin = new System.Windows.Forms.Label();
            this.Cast_label_Admin = new System.Windows.Forms.Label();
            this.MovieID_Label_Admin = new System.Windows.Forms.Label();
            this.Title_label_Admin = new System.Windows.Forms.Label();
            this.UserID_Movie_Label_Admin = new System.Windows.Forms.Label();
            this.UserID_Movie_textBox_Admin = new System.Windows.Forms.TextBox();
            this.usidwronglabel = new System.Windows.Forms.Label();
            this.UserID_User_Label_Admin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviedataGridView_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // pwronglabel
            // 
            this.pwronglabel.AutoSize = true;
            this.pwronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.pwronglabel.ForeColor = System.Drawing.Color.Red;
            this.pwronglabel.Location = new System.Drawing.Point(954, 93);
            this.pwronglabel.Name = "pwronglabel";
            this.pwronglabel.Size = new System.Drawing.Size(14, 17);
            this.pwronglabel.TabIndex = 28;
            this.pwronglabel.Text = "*";
            this.pwronglabel.Visible = false;
            // 
            // uwronglabel
            // 
            this.uwronglabel.AutoSize = true;
            this.uwronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.uwronglabel.ForeColor = System.Drawing.Color.Red;
            this.uwronglabel.Location = new System.Drawing.Point(954, 54);
            this.uwronglabel.Name = "uwronglabel";
            this.uwronglabel.Size = new System.Drawing.Size(14, 17);
            this.uwronglabel.TabIndex = 27;
            this.uwronglabel.Text = "*";
            this.uwronglabel.Visible = false;
            // 
            // Delete_User_button_Admin
            // 
            this.Delete_User_button_Admin.Location = new System.Drawing.Point(692, 215);
            this.Delete_User_button_Admin.Name = "Delete_User_button_Admin";
            this.Delete_User_button_Admin.Size = new System.Drawing.Size(119, 49);
            this.Delete_User_button_Admin.TabIndex = 25;
            this.Delete_User_button_Admin.Text = "Delete";
            this.Delete_User_button_Admin.UseVisualStyleBackColor = true;
            this.Delete_User_button_Admin.Click += new System.EventHandler(this.Delete_User_button_Admin_Click);
            // 
            // Update_User_button_Admin
            // 
            this.Update_User_button_Admin.Location = new System.Drawing.Point(692, 288);
            this.Update_User_button_Admin.Name = "Update_User_button_Admin";
            this.Update_User_button_Admin.Size = new System.Drawing.Size(119, 49);
            this.Update_User_button_Admin.TabIndex = 24;
            this.Update_User_button_Admin.Text = "Update";
            this.Update_User_button_Admin.UseVisualStyleBackColor = true;
            this.Update_User_button_Admin.Click += new System.EventHandler(this.Update_User_button_Admin_Click);
            // 
            // Add_User_button_Admin
            // 
            this.Add_User_button_Admin.Location = new System.Drawing.Point(692, 135);
            this.Add_User_button_Admin.Name = "Add_User_button_Admin";
            this.Add_User_button_Admin.Size = new System.Drawing.Size(119, 49);
            this.Add_User_button_Admin.TabIndex = 23;
            this.Add_User_button_Admin.Text = "Add";
            this.Add_User_button_Admin.UseVisualStyleBackColor = true;
            this.Add_User_button_Admin.Click += new System.EventHandler(this.Add_button_Click_Admin);
            // 
            // UserdataGridView_Admin
            // 
            this.UserdataGridView_Admin.AllowUserToAddRows = false;
            this.UserdataGridView_Admin.AllowUserToDeleteRows = false;
            this.UserdataGridView_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserdataGridView_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView_Admin.Location = new System.Drawing.Point(692, 371);
            this.UserdataGridView_Admin.Name = "UserdataGridView_Admin";
            this.UserdataGridView_Admin.ReadOnly = true;
            this.UserdataGridView_Admin.Size = new System.Drawing.Size(387, 259);
            this.UserdataGridView_Admin.TabIndex = 22;
            this.UserdataGridView_Admin.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserdataGridView_Admin_CellEnter);
            // 
            // Password_textBox_Admin
            // 
            this.Password_textBox_Admin.Location = new System.Drawing.Point(766, 89);
            this.Password_textBox_Admin.Name = "Password_textBox_Admin";
            this.Password_textBox_Admin.Size = new System.Drawing.Size(182, 20);
            this.Password_textBox_Admin.TabIndex = 16;
            // 
            // Username_textBox_Admin
            // 
            this.Username_textBox_Admin.Location = new System.Drawing.Point(766, 50);
            this.Username_textBox_Admin.Name = "Username_textBox_Admin";
            this.Username_textBox_Admin.Size = new System.Drawing.Size(182, 20);
            this.Username_textBox_Admin.TabIndex = 15;
            // 
            // Password_label_Admin
            // 
            this.Password_label_Admin.AutoSize = true;
            this.Password_label_Admin.Location = new System.Drawing.Point(689, 96);
            this.Password_label_Admin.Name = "Password_label_Admin";
            this.Password_label_Admin.Size = new System.Drawing.Size(53, 13);
            this.Password_label_Admin.TabIndex = 11;
            this.Password_label_Admin.Text = "Password";
            // 
            // Username_label_Admin
            // 
            this.Username_label_Admin.AutoSize = true;
            this.Username_label_Admin.Location = new System.Drawing.Point(689, 57);
            this.Username_label_Admin.Name = "Username_label_Admin";
            this.Username_label_Admin.Size = new System.Drawing.Size(55, 13);
            this.Username_label_Admin.TabIndex = 7;
            this.Username_label_Admin.Text = "Username";
            // 
            // rrwronglabel
            // 
            this.rrwronglabel.AutoSize = true;
            this.rrwronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.rrwronglabel.ForeColor = System.Drawing.Color.Red;
            this.rrwronglabel.Location = new System.Drawing.Point(290, 183);
            this.rrwronglabel.Name = "rrwronglabel";
            this.rrwronglabel.Size = new System.Drawing.Size(14, 17);
            this.rrwronglabel.TabIndex = 54;
            this.rrwronglabel.Text = "*";
            this.rrwronglabel.Visible = false;
            // 
            // rwronglabel
            // 
            this.rwronglabel.AutoSize = true;
            this.rwronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.rwronglabel.ForeColor = System.Drawing.Color.Red;
            this.rwronglabel.Location = new System.Drawing.Point(290, 157);
            this.rwronglabel.Name = "rwronglabel";
            this.rwronglabel.Size = new System.Drawing.Size(14, 17);
            this.rwronglabel.TabIndex = 53;
            this.rwronglabel.Text = "*";
            this.rwronglabel.Visible = false;
            // 
            // gwronglabel
            // 
            this.gwronglabel.AutoSize = true;
            this.gwronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.gwronglabel.ForeColor = System.Drawing.Color.Red;
            this.gwronglabel.Location = new System.Drawing.Point(290, 128);
            this.gwronglabel.Name = "gwronglabel";
            this.gwronglabel.Size = new System.Drawing.Size(14, 17);
            this.gwronglabel.TabIndex = 52;
            this.gwronglabel.Text = "*";
            this.gwronglabel.Visible = false;
            // 
            // cwronglabel
            // 
            this.cwronglabel.AutoSize = true;
            this.cwronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.cwronglabel.ForeColor = System.Drawing.Color.Red;
            this.cwronglabel.Location = new System.Drawing.Point(290, 103);
            this.cwronglabel.Name = "cwronglabel";
            this.cwronglabel.Size = new System.Drawing.Size(14, 17);
            this.cwronglabel.TabIndex = 51;
            this.cwronglabel.Text = "*";
            this.cwronglabel.Visible = false;
            // 
            // dwronglabel
            // 
            this.dwronglabel.AutoSize = true;
            this.dwronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.dwronglabel.ForeColor = System.Drawing.Color.Red;
            this.dwronglabel.Location = new System.Drawing.Point(290, 77);
            this.dwronglabel.Name = "dwronglabel";
            this.dwronglabel.Size = new System.Drawing.Size(14, 17);
            this.dwronglabel.TabIndex = 50;
            this.dwronglabel.Text = "*";
            this.dwronglabel.Visible = false;
            // 
            // twronglabel
            // 
            this.twronglabel.AutoSize = true;
            this.twronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.twronglabel.ForeColor = System.Drawing.Color.Red;
            this.twronglabel.Location = new System.Drawing.Point(290, 29);
            this.twronglabel.Name = "twronglabel";
            this.twronglabel.Size = new System.Drawing.Size(14, 17);
            this.twronglabel.TabIndex = 49;
            this.twronglabel.Text = "*";
            this.twronglabel.Visible = false;
            // 
            // Delete_Movie_button_Admin
            // 
            this.Delete_Movie_button_Admin.Location = new System.Drawing.Point(529, 288);
            this.Delete_Movie_button_Admin.Name = "Delete_Movie_button_Admin";
            this.Delete_Movie_button_Admin.Size = new System.Drawing.Size(119, 49);
            this.Delete_Movie_button_Admin.TabIndex = 47;
            this.Delete_Movie_button_Admin.Text = "Delete";
            this.Delete_Movie_button_Admin.UseVisualStyleBackColor = true;
            this.Delete_Movie_button_Admin.Click += new System.EventHandler(this.Delete_Movie_button_Admin_Click);
            // 
            // Update_Movie_button_Admin
            // 
            this.Update_Movie_button_Admin.Location = new System.Drawing.Point(529, 206);
            this.Update_Movie_button_Admin.Name = "Update_Movie_button_Admin";
            this.Update_Movie_button_Admin.Size = new System.Drawing.Size(119, 49);
            this.Update_Movie_button_Admin.TabIndex = 46;
            this.Update_Movie_button_Admin.Text = "Update";
            this.Update_Movie_button_Admin.UseVisualStyleBackColor = true;
            this.Update_Movie_button_Admin.Click += new System.EventHandler(this.Update_Movie_button_Admin_Click);
            // 
            // Add_Movie_Button_Admin
            // 
            this.Add_Movie_Button_Admin.Location = new System.Drawing.Point(529, 135);
            this.Add_Movie_Button_Admin.Name = "Add_Movie_Button_Admin";
            this.Add_Movie_Button_Admin.Size = new System.Drawing.Size(119, 49);
            this.Add_Movie_Button_Admin.TabIndex = 45;
            this.Add_Movie_Button_Admin.Text = "Add";
            this.Add_Movie_Button_Admin.UseVisualStyleBackColor = true;
            this.Add_Movie_Button_Admin.Click += new System.EventHandler(this.Add_Movie_Button_Admin_Click);
            // 
            // MoviedataGridView_Admin
            // 
            this.MoviedataGridView_Admin.AllowUserToAddRows = false;
            this.MoviedataGridView_Admin.AllowUserToDeleteRows = false;
            this.MoviedataGridView_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoviedataGridView_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviedataGridView_Admin.Location = new System.Drawing.Point(18, 371);
            this.MoviedataGridView_Admin.Name = "MoviedataGridView_Admin";
            this.MoviedataGridView_Admin.ReadOnly = true;
            this.MoviedataGridView_Admin.Size = new System.Drawing.Size(630, 259);
            this.MoviedataGridView_Admin.TabIndex = 44;
            this.MoviedataGridView_Admin.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviedataGridView_Admin_CellEnter);
            // 
            // Description_textBox_Admin
            // 
            this.Description_textBox_Admin.Location = new System.Drawing.Point(102, 206);
            this.Description_textBox_Admin.Multiline = true;
            this.Description_textBox_Admin.Name = "Description_textBox_Admin";
            this.Description_textBox_Admin.Size = new System.Drawing.Size(182, 128);
            this.Description_textBox_Admin.TabIndex = 43;
            // 
            // Rating_textBox_Admin
            // 
            this.Rating_textBox_Admin.Location = new System.Drawing.Point(102, 180);
            this.Rating_textBox_Admin.Name = "Rating_textBox_Admin";
            this.Rating_textBox_Admin.Size = new System.Drawing.Size(182, 20);
            this.Rating_textBox_Admin.TabIndex = 42;
            // 
            // Release_Year_textBox_Admin
            // 
            this.Release_Year_textBox_Admin.Location = new System.Drawing.Point(102, 154);
            this.Release_Year_textBox_Admin.Name = "Release_Year_textBox_Admin";
            this.Release_Year_textBox_Admin.Size = new System.Drawing.Size(182, 20);
            this.Release_Year_textBox_Admin.TabIndex = 41;
            // 
            // Genre_textBox_Admin
            // 
            this.Genre_textBox_Admin.Location = new System.Drawing.Point(102, 125);
            this.Genre_textBox_Admin.Name = "Genre_textBox_Admin";
            this.Genre_textBox_Admin.Size = new System.Drawing.Size(182, 20);
            this.Genre_textBox_Admin.TabIndex = 40;
            // 
            // Cast_textBox_Admin
            // 
            this.Cast_textBox_Admin.Location = new System.Drawing.Point(102, 99);
            this.Cast_textBox_Admin.Name = "Cast_textBox_Admin";
            this.Cast_textBox_Admin.Size = new System.Drawing.Size(182, 20);
            this.Cast_textBox_Admin.TabIndex = 39;
            // 
            // Director_textBox_Admin
            // 
            this.Director_textBox_Admin.Location = new System.Drawing.Point(102, 73);
            this.Director_textBox_Admin.Name = "Director_textBox_Admin";
            this.Director_textBox_Admin.Size = new System.Drawing.Size(182, 20);
            this.Director_textBox_Admin.TabIndex = 38;
            // 
            // Title_textBox_Admin
            // 
            this.Title_textBox_Admin.Location = new System.Drawing.Point(102, 25);
            this.Title_textBox_Admin.Name = "Title_textBox_Admin";
            this.Title_textBox_Admin.Size = new System.Drawing.Size(182, 20);
            this.Title_textBox_Admin.TabIndex = 37;
            // 
            // Description_label_Admin
            // 
            this.Description_label_Admin.AutoSize = true;
            this.Description_label_Admin.Location = new System.Drawing.Point(25, 212);
            this.Description_label_Admin.Name = "Description_label_Admin";
            this.Description_label_Admin.Size = new System.Drawing.Size(60, 13);
            this.Description_label_Admin.TabIndex = 36;
            this.Description_label_Admin.Text = "Description";
            // 
            // Rating_label_Admin
            // 
            this.Rating_label_Admin.AutoSize = true;
            this.Rating_label_Admin.Location = new System.Drawing.Point(25, 183);
            this.Rating_label_Admin.Name = "Rating_label_Admin";
            this.Rating_label_Admin.Size = new System.Drawing.Size(38, 13);
            this.Rating_label_Admin.TabIndex = 35;
            this.Rating_label_Admin.Text = "Rating";
            // 
            // Genre_label_Admin
            // 
            this.Genre_label_Admin.AutoSize = true;
            this.Genre_label_Admin.Location = new System.Drawing.Point(25, 132);
            this.Genre_label_Admin.Name = "Genre_label_Admin";
            this.Genre_label_Admin.Size = new System.Drawing.Size(36, 13);
            this.Genre_label_Admin.TabIndex = 34;
            this.Genre_label_Admin.Text = "Genre";
            // 
            // Release_Year_label_Admin
            // 
            this.Release_Year_label_Admin.AutoSize = true;
            this.Release_Year_label_Admin.Location = new System.Drawing.Point(25, 157);
            this.Release_Year_label_Admin.Name = "Release_Year_label_Admin";
            this.Release_Year_label_Admin.Size = new System.Drawing.Size(71, 13);
            this.Release_Year_label_Admin.TabIndex = 31;
            this.Release_Year_label_Admin.Text = "Release Year";
            // 
            // Director_label_Admin
            // 
            this.Director_label_Admin.AutoSize = true;
            this.Director_label_Admin.Location = new System.Drawing.Point(25, 80);
            this.Director_label_Admin.Name = "Director_label_Admin";
            this.Director_label_Admin.Size = new System.Drawing.Size(44, 13);
            this.Director_label_Admin.TabIndex = 33;
            this.Director_label_Admin.Text = "Director";
            // 
            // Cast_label_Admin
            // 
            this.Cast_label_Admin.AutoSize = true;
            this.Cast_label_Admin.Location = new System.Drawing.Point(25, 106);
            this.Cast_label_Admin.Name = "Cast_label_Admin";
            this.Cast_label_Admin.Size = new System.Drawing.Size(28, 13);
            this.Cast_label_Admin.TabIndex = 30;
            this.Cast_label_Admin.Text = "Cast";
            // 
            // MovieID_Label_Admin
            // 
            this.MovieID_Label_Admin.AutoSize = true;
            this.MovieID_Label_Admin.Location = new System.Drawing.Point(25, 681);
            this.MovieID_Label_Admin.Name = "MovieID_Label_Admin";
            this.MovieID_Label_Admin.Size = new System.Drawing.Size(84, 13);
            this.MovieID_Label_Admin.TabIndex = 32;
            this.MovieID_Label_Admin.Text = "MovieID(Secret)";
            this.MovieID_Label_Admin.Visible = false;
            // 
            // Title_label_Admin
            // 
            this.Title_label_Admin.AutoSize = true;
            this.Title_label_Admin.Location = new System.Drawing.Point(25, 32);
            this.Title_label_Admin.Name = "Title_label_Admin";
            this.Title_label_Admin.Size = new System.Drawing.Size(27, 13);
            this.Title_label_Admin.TabIndex = 29;
            this.Title_label_Admin.Text = "Title";
            // 
            // UserID_Movie_Label_Admin
            // 
            this.UserID_Movie_Label_Admin.AutoSize = true;
            this.UserID_Movie_Label_Admin.Location = new System.Drawing.Point(25, 54);
            this.UserID_Movie_Label_Admin.Name = "UserID_Movie_Label_Admin";
            this.UserID_Movie_Label_Admin.Size = new System.Drawing.Size(40, 13);
            this.UserID_Movie_Label_Admin.TabIndex = 55;
            this.UserID_Movie_Label_Admin.Text = "UserID";
            // 
            // UserID_Movie_textBox_Admin
            // 
            this.UserID_Movie_textBox_Admin.Location = new System.Drawing.Point(102, 50);
            this.UserID_Movie_textBox_Admin.Name = "UserID_Movie_textBox_Admin";
            this.UserID_Movie_textBox_Admin.Size = new System.Drawing.Size(182, 20);
            this.UserID_Movie_textBox_Admin.TabIndex = 37;
            // 
            // usidwronglabel
            // 
            this.usidwronglabel.AutoSize = true;
            this.usidwronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.usidwronglabel.ForeColor = System.Drawing.Color.Red;
            this.usidwronglabel.Location = new System.Drawing.Point(290, 54);
            this.usidwronglabel.Name = "usidwronglabel";
            this.usidwronglabel.Size = new System.Drawing.Size(14, 17);
            this.usidwronglabel.TabIndex = 49;
            this.usidwronglabel.Text = "*";
            this.usidwronglabel.Visible = false;
            // 
            // UserID_User_Label_Admin
            // 
            this.UserID_User_Label_Admin.AutoSize = true;
            this.UserID_User_Label_Admin.Location = new System.Drawing.Point(115, 681);
            this.UserID_User_Label_Admin.Name = "UserID_User_Label_Admin";
            this.UserID_User_Label_Admin.Size = new System.Drawing.Size(77, 13);
            this.UserID_User_Label_Admin.TabIndex = 55;
            this.UserID_User_Label_Admin.Text = "UserID(Secret)";
            this.UserID_User_Label_Admin.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(817, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "All movies saved by the user you delete will be deleted!";
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 713);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserID_User_Label_Admin);
            this.Controls.Add(this.UserID_Movie_Label_Admin);
            this.Controls.Add(this.rrwronglabel);
            this.Controls.Add(this.rwronglabel);
            this.Controls.Add(this.gwronglabel);
            this.Controls.Add(this.cwronglabel);
            this.Controls.Add(this.dwronglabel);
            this.Controls.Add(this.usidwronglabel);
            this.Controls.Add(this.twronglabel);
            this.Controls.Add(this.Delete_Movie_button_Admin);
            this.Controls.Add(this.Update_Movie_button_Admin);
            this.Controls.Add(this.Add_Movie_Button_Admin);
            this.Controls.Add(this.MoviedataGridView_Admin);
            this.Controls.Add(this.Description_textBox_Admin);
            this.Controls.Add(this.Rating_textBox_Admin);
            this.Controls.Add(this.Release_Year_textBox_Admin);
            this.Controls.Add(this.Genre_textBox_Admin);
            this.Controls.Add(this.Cast_textBox_Admin);
            this.Controls.Add(this.Director_textBox_Admin);
            this.Controls.Add(this.UserID_Movie_textBox_Admin);
            this.Controls.Add(this.Title_textBox_Admin);
            this.Controls.Add(this.Description_label_Admin);
            this.Controls.Add(this.Rating_label_Admin);
            this.Controls.Add(this.Genre_label_Admin);
            this.Controls.Add(this.Release_Year_label_Admin);
            this.Controls.Add(this.Director_label_Admin);
            this.Controls.Add(this.Cast_label_Admin);
            this.Controls.Add(this.MovieID_Label_Admin);
            this.Controls.Add(this.Title_label_Admin);
            this.Controls.Add(this.pwronglabel);
            this.Controls.Add(this.uwronglabel);
            this.Controls.Add(this.Delete_User_button_Admin);
            this.Controls.Add(this.Update_User_button_Admin);
            this.Controls.Add(this.Add_User_button_Admin);
            this.Controls.Add(this.UserdataGridView_Admin);
            this.Controls.Add(this.Password_textBox_Admin);
            this.Controls.Add(this.Username_textBox_Admin);
            this.Controls.Add(this.Password_label_Admin);
            this.Controls.Add(this.Username_label_Admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviedataGridView_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pwronglabel;
        private System.Windows.Forms.Label uwronglabel;
        private System.Windows.Forms.Button Delete_User_button_Admin;
        private System.Windows.Forms.Button Update_User_button_Admin;
        private System.Windows.Forms.Button Add_User_button_Admin;
        private System.Windows.Forms.DataGridView UserdataGridView_Admin;
        private System.Windows.Forms.TextBox Password_textBox_Admin;
        private System.Windows.Forms.TextBox Username_textBox_Admin;
        private System.Windows.Forms.Label Password_label_Admin;
        private System.Windows.Forms.Label Username_label_Admin;
        private System.Windows.Forms.Label rrwronglabel;
        private System.Windows.Forms.Label rwronglabel;
        private System.Windows.Forms.Label gwronglabel;
        private System.Windows.Forms.Label cwronglabel;
        private System.Windows.Forms.Label dwronglabel;
        private System.Windows.Forms.Label twronglabel;
        private System.Windows.Forms.Button Delete_Movie_button_Admin;
        private System.Windows.Forms.Button Update_Movie_button_Admin;
        private System.Windows.Forms.Button Add_Movie_Button_Admin;
        private System.Windows.Forms.DataGridView MoviedataGridView_Admin;
        private System.Windows.Forms.TextBox Description_textBox_Admin;
        private System.Windows.Forms.TextBox Rating_textBox_Admin;
        private System.Windows.Forms.TextBox Release_Year_textBox_Admin;
        private System.Windows.Forms.TextBox Genre_textBox_Admin;
        private System.Windows.Forms.TextBox Cast_textBox_Admin;
        private System.Windows.Forms.TextBox Director_textBox_Admin;
        private System.Windows.Forms.TextBox Title_textBox_Admin;
        private System.Windows.Forms.Label Description_label_Admin;
        private System.Windows.Forms.Label Rating_label_Admin;
        private System.Windows.Forms.Label Genre_label_Admin;
        private System.Windows.Forms.Label Release_Year_label_Admin;
        private System.Windows.Forms.Label Director_label_Admin;
        private System.Windows.Forms.Label Cast_label_Admin;
        private System.Windows.Forms.Label MovieID_Label_Admin;
        private System.Windows.Forms.Label Title_label_Admin;
        private System.Windows.Forms.Label UserID_Movie_Label_Admin;
        private System.Windows.Forms.TextBox UserID_Movie_textBox_Admin;
        private System.Windows.Forms.Label usidwronglabel;
        private System.Windows.Forms.Label UserID_User_Label_Admin;
        private System.Windows.Forms.Label label1;
    }
}