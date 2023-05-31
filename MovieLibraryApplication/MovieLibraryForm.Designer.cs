namespace MovieLibraryApplication
{
    partial class MovieLibraryForm
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
            this.Title_label = new System.Windows.Forms.Label();
            this.Director_label = new System.Windows.Forms.Label();
            this.Cast_label = new System.Windows.Forms.Label();
            this.Genre_label = new System.Windows.Forms.Label();
            this.Release_Year_label = new System.Windows.Forms.Label();
            this.Rating_label = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.Title_textBox = new System.Windows.Forms.TextBox();
            this.Release_Year_textBox = new System.Windows.Forms.TextBox();
            this.Director_textBox = new System.Windows.Forms.TextBox();
            this.Cast_textBox = new System.Windows.Forms.TextBox();
            this.Genre_textBox = new System.Windows.Forms.TextBox();
            this.Rating_textBox = new System.Windows.Forms.TextBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.MovieID_Label = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Location = new System.Drawing.Point(29, 31);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(27, 13);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Title";
            // 
            // Director_label
            // 
            this.Director_label.AutoSize = true;
            this.Director_label.Location = new System.Drawing.Point(29, 58);
            this.Director_label.Name = "Director_label";
            this.Director_label.Size = new System.Drawing.Size(44, 13);
            this.Director_label.TabIndex = 1;
            this.Director_label.Text = "Director";
            // 
            // Cast_label
            // 
            this.Cast_label.AutoSize = true;
            this.Cast_label.Location = new System.Drawing.Point(29, 84);
            this.Cast_label.Name = "Cast_label";
            this.Cast_label.Size = new System.Drawing.Size(28, 13);
            this.Cast_label.TabIndex = 0;
            this.Cast_label.Text = "Cast";
            // 
            // Genre_label
            // 
            this.Genre_label.AutoSize = true;
            this.Genre_label.Location = new System.Drawing.Point(29, 110);
            this.Genre_label.Name = "Genre_label";
            this.Genre_label.Size = new System.Drawing.Size(36, 13);
            this.Genre_label.TabIndex = 1;
            this.Genre_label.Text = "Genre";
            // 
            // Release_Year_label
            // 
            this.Release_Year_label.AutoSize = true;
            this.Release_Year_label.Location = new System.Drawing.Point(29, 135);
            this.Release_Year_label.Name = "Release_Year_label";
            this.Release_Year_label.Size = new System.Drawing.Size(71, 13);
            this.Release_Year_label.TabIndex = 0;
            this.Release_Year_label.Text = "Release Year";
            // 
            // Rating_label
            // 
            this.Rating_label.AutoSize = true;
            this.Rating_label.Location = new System.Drawing.Point(29, 161);
            this.Rating_label.Name = "Rating_label";
            this.Rating_label.Size = new System.Drawing.Size(38, 13);
            this.Rating_label.TabIndex = 1;
            this.Rating_label.Text = "Rating";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(29, 190);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(60, 13);
            this.Description_label.TabIndex = 1;
            this.Description_label.Text = "Description";
            // 
            // Title_textBox
            // 
            this.Title_textBox.Location = new System.Drawing.Point(106, 24);
            this.Title_textBox.Name = "Title_textBox";
            this.Title_textBox.Size = new System.Drawing.Size(182, 20);
            this.Title_textBox.TabIndex = 2;
            // 
            // Release_Year_textBox
            // 
            this.Release_Year_textBox.Location = new System.Drawing.Point(106, 132);
            this.Release_Year_textBox.Name = "Release_Year_textBox";
            this.Release_Year_textBox.Size = new System.Drawing.Size(182, 20);
            this.Release_Year_textBox.TabIndex = 2;
            // 
            // Director_textBox
            // 
            this.Director_textBox.Location = new System.Drawing.Point(106, 51);
            this.Director_textBox.Name = "Director_textBox";
            this.Director_textBox.Size = new System.Drawing.Size(182, 20);
            this.Director_textBox.TabIndex = 2;
            // 
            // Cast_textBox
            // 
            this.Cast_textBox.Location = new System.Drawing.Point(106, 77);
            this.Cast_textBox.Name = "Cast_textBox";
            this.Cast_textBox.Size = new System.Drawing.Size(182, 20);
            this.Cast_textBox.TabIndex = 2;
            // 
            // Genre_textBox
            // 
            this.Genre_textBox.Location = new System.Drawing.Point(106, 103);
            this.Genre_textBox.Name = "Genre_textBox";
            this.Genre_textBox.Size = new System.Drawing.Size(182, 20);
            this.Genre_textBox.TabIndex = 2;
            // 
            // Rating_textBox
            // 
            this.Rating_textBox.Location = new System.Drawing.Point(106, 158);
            this.Rating_textBox.Name = "Rating_textBox";
            this.Rating_textBox.Size = new System.Drawing.Size(182, 20);
            this.Rating_textBox.TabIndex = 2;
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(106, 184);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(182, 128);
            this.Description_textBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(630, 259);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(525, 110);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(119, 49);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(525, 184);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(119, 49);
            this.Update_button.TabIndex = 4;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(525, 263);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(119, 49);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // MovieID_Label
            // 
            this.MovieID_Label.AutoSize = true;
            this.MovieID_Label.Location = new System.Drawing.Point(39, 656);
            this.MovieID_Label.Name = "MovieID_Label";
            this.MovieID_Label.Size = new System.Drawing.Size(84, 13);
            this.MovieID_Label.TabIndex = 0;
            this.MovieID_Label.Text = "MovieID(Secret)";
            this.MovieID_Label.Visible = false;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(129, 656);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(77, 13);
            this.idlbl.TabIndex = 5;
            this.idlbl.Text = "UserID(Secret)";
            this.idlbl.Visible = false;
            // 
            // MovieLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 678);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Rating_textBox);
            this.Controls.Add(this.Release_Year_textBox);
            this.Controls.Add(this.Genre_textBox);
            this.Controls.Add(this.Cast_textBox);
            this.Controls.Add(this.Director_textBox);
            this.Controls.Add(this.Title_textBox);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Rating_label);
            this.Controls.Add(this.Genre_label);
            this.Controls.Add(this.Release_Year_label);
            this.Controls.Add(this.Director_label);
            this.Controls.Add(this.Cast_label);
            this.Controls.Add(this.MovieID_Label);
            this.Controls.Add(this.Title_label);
            this.Name = "MovieLibraryForm";
            this.Text = "MovieLibraryForm";
            this.Load += new System.EventHandler(this.MovieLibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label Director_label;
        private System.Windows.Forms.Label Cast_label;
        private System.Windows.Forms.Label Genre_label;
        private System.Windows.Forms.Label Release_Year_label;
        private System.Windows.Forms.Label Rating_label;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.TextBox Title_textBox;
        private System.Windows.Forms.TextBox Release_Year_textBox;
        private System.Windows.Forms.TextBox Director_textBox;
        private System.Windows.Forms.TextBox Cast_textBox;
        private System.Windows.Forms.TextBox Genre_textBox;
        private System.Windows.Forms.TextBox Rating_textBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label MovieID_Label;
        private System.Windows.Forms.Label idlbl;
    }
}