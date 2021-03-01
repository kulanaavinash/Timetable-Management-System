
namespace Time_table_Management_System
{
    partial class Location
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Locations = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loc_tabcontrol = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.oc_tabcontrol = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Hwbtn = new System.Windows.Forms.Button();
            this.view_Location1 = new Time_table_Management_System.Locations.View_Location();
            this.add_location1 = new Time_table_Management_System.Locations.Add_location();
            this.edit_Delete_Location1 = new Time_table_Management_System.Locations.Edit_Delete_Location();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.edit_Delete_Location1);
            this.panel1.Controls.Add(this.add_location1);
            this.panel1.Controls.Add(this.view_Location1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(117, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 592);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Locations);
            this.panel3.Location = new System.Drawing.Point(20, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 86);
            this.panel3.TabIndex = 3;
            // 
            // Locations
            // 
            this.Locations.AutoSize = true;
            this.Locations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Locations.Font = new System.Drawing.Font("Abhaya Libre ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locations.Location = new System.Drawing.Point(15, 29);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(126, 32);
            this.Locations.TabIndex = 2;
            this.Locations.Text = "Locations";
            this.Locations.Click += new System.EventHandler(this.label2_Click_3);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.loc_tabcontrol);
            this.panel4.Controls.Add(this.button17);
            this.panel4.Controls.Add(this.oc_tabcontrol);
            this.panel4.Location = new System.Drawing.Point(170, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(769, 61);
            this.panel4.TabIndex = 1;
            // 
            // loc_tabcontrol
            // 
            this.loc_tabcontrol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loc_tabcontrol.Location = new System.Drawing.Point(78, 32);
            this.loc_tabcontrol.Name = "loc_tabcontrol";
            this.loc_tabcontrol.Size = new System.Drawing.Size(128, 26);
            this.loc_tabcontrol.TabIndex = 0;
            this.loc_tabcontrol.Text = "View Locations";
            this.loc_tabcontrol.UseVisualStyleBackColor = true;
            this.loc_tabcontrol.Click += new System.EventHandler(this.loc_tabcontrol_Click);
            // 
            // button17
            // 
            this.button17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button17.Location = new System.Drawing.Point(481, 35);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(169, 27);
            this.button17.TabIndex = 2;
            this.button17.Text = "Edit/Delete Locations";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // oc_tabcontrol
            // 
            this.oc_tabcontrol.ForeColor = System.Drawing.SystemColors.Desktop;
            this.oc_tabcontrol.Location = new System.Drawing.Point(276, 35);
            this.oc_tabcontrol.Name = "oc_tabcontrol";
            this.oc_tabcontrol.Size = new System.Drawing.Size(129, 26);
            this.oc_tabcontrol.TabIndex = 1;
            this.oc_tabcontrol.Text = "Add Locations ";
            this.oc_tabcontrol.UseVisualStyleBackColor = true;
            this.oc_tabcontrol.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 96);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "HomePage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_2341531;
            this.pictureBox1.Location = new System.Drawing.Point(34, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button8.Location = new System.Drawing.Point(170, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 51);
            this.button8.TabIndex = 3;
            this.button8.Text = "Home";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_home_header);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(484, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Rooms";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_rooms_header);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Location = new System.Drawing.Point(649, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Advanced";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_advanced_header);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Location = new System.Drawing.Point(820, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Genarate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_genarate_header);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(318, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sessions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_sessions_header);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Image = global::Time_table_Management_System.Properties.Resources.oo;
            this.button14.Location = new System.Drawing.Point(980, 9);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(15, 17);
            this.button14.TabIndex = 0;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Image = global::Time_table_Management_System.Properties.Resources.uu__1_;
            this.button13.Location = new System.Drawing.Point(1001, 7);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(20, 20);
            this.button13.TabIndex = 0;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::Time_table_Management_System.Properties.Resources.ne__2___1_;
            this.button12.Location = new System.Drawing.Point(1027, 7);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(20, 20);
            this.button12.TabIndex = 0;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button11.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_1203275__2_;
            this.button11.Location = new System.Drawing.Point(11, 492);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 83);
            this.button11.TabIndex = 13;
            this.button11.Text = "Location";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btn_locations_nav);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button10.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_511570__1_;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(8, 581);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 78);
            this.button10.TabIndex = 0;
            this.button10.Text = "Statics";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btn_statics_nav);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button9.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_1110775__1_;
            this.button9.Location = new System.Drawing.Point(8, 403);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 67);
            this.button9.TabIndex = 12;
            this.button9.Text = "Tags";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_tags_nav);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button7.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_1083954__1_;
            this.button7.Location = new System.Drawing.Point(8, 319);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 78);
            this.button7.TabIndex = 11;
            this.button7.Text = "Students";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_students_nav);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button6.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_58351__1_;
            this.button6.Location = new System.Drawing.Point(8, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 71);
            this.button6.TabIndex = 9;
            this.button6.Text = "Subjects";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_subjects_nav);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button5.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_266447__1_;
            this.button5.Location = new System.Drawing.Point(2, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 73);
            this.button5.TabIndex = 8;
            this.button5.Text = "Lectures";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_lectures_nav);
            // 
            // Hwbtn
            // 
            this.Hwbtn.FlatAppearance.BorderSize = 0;
            this.Hwbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hwbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hwbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Hwbtn.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_176187__1___1_;
            this.Hwbtn.Location = new System.Drawing.Point(2, 103);
            this.Hwbtn.Name = "Hwbtn";
            this.Hwbtn.Size = new System.Drawing.Size(113, 86);
            this.Hwbtn.TabIndex = 2;
            this.Hwbtn.Text = "Working Days\r\n Hours";
            this.Hwbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Hwbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Hwbtn.UseVisualStyleBackColor = true;
            this.Hwbtn.Click += new System.EventHandler(this.btn_days_nav);
            // 
            // view_Location1
            // 
            this.view_Location1.Location = new System.Drawing.Point(143, 97);
            this.view_Location1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.view_Location1.Name = "view_Location1";
            this.view_Location1.Size = new System.Drawing.Size(677, 436);
            this.view_Location1.TabIndex = 4;
            // 
            // add_location1
            // 
            this.add_location1.Location = new System.Drawing.Point(151, 72);
            this.add_location1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_location1.Name = "add_location1";
            this.add_location1.Size = new System.Drawing.Size(717, 506);
            this.add_location1.TabIndex = 5;
            // 
            // edit_Delete_Location1
            // 
            this.edit_Delete_Location1.Location = new System.Drawing.Point(154, 72);
            this.edit_Delete_Location1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit_Delete_Location1.Name = "edit_Delete_Location1";
            this.edit_Delete_Location1.Size = new System.Drawing.Size(750, 524);
            this.edit_Delete_Location1.TabIndex = 6;
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1061, 695);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Hwbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Hwbtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button oc_tabcontrol;
        private System.Windows.Forms.Button loc_tabcontrol;
        private System.Windows.Forms.Label Locations;
        private System.Windows.Forms.Panel panel3;
        private Locations.Edit_Delete_Location edit_Delete_Location1;
        private Locations.Add_location add_location1;
        private Locations.View_Location view_Location1;
    }
}

