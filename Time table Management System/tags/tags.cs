﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;

namespace Time_table_Management_System
{

    public partial class tags : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True");
        string cs = "Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;



        //ID variable used in Updating and Deleting Record  
        int TagID = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public tags()
        {
            InitializeComponent();
            DisplayData();



            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dashboard panel main
        }


        private void label1_Click(object sender, EventArgs e)
        {
            //label home
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //form
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage f2 = new Homepage();
            f2.Show(); //picturebox panel  
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //panel dashboard
        }










        //--------------Header icons------------------//
        private void btn_home_header(object sender, EventArgs e)
        {
            this.Hide();
            Homepage f2 = new Homepage();
            f2.Show();
        }

        private void btn_sessions_header(object sender, EventArgs e)
        {
            this.Hide();
            Sessions f2 = new Sessions();
            f2.Show();
        }

        private void btn_rooms_header(object sender, EventArgs e)
        {
            this.Hide();
            Room f2 = new Room();
            f2.Show();
        }

        private void btn_advanced_header(object sender, EventArgs e)
        {
            this.Hide();
            Advanced f2 = new Advanced();
            f2.Show();
        }

        private void btn_genarate_header(object sender, EventArgs e)
        {
            this.Hide();
            Generate f2 = new Generate();
            f2.Show();
        }









        //------------------Slide navbar icons....................//
        private void btn_days_nav(object sender, EventArgs e)
        {
            this.Hide();
            DaysHours f2 = new DaysHours();
            f2.Show();
        }

        private void btn_lectures_nav(object sender, EventArgs e)
        {
            this.Hide();
            Lectures f2 = new Lectures();
            f2.Show();
        }

        private void btn_subjects_nav(object sender, EventArgs e)
        {
            this.Hide();
            Subjects.Subjects f2 = new Subjects.Subjects();
            f2.Show();
        }

        private void btn_students_nav(object sender, EventArgs e)
        {
            this.Hide();
            students f2 = new students();
            f2.Show();
        }

        private void btn_tags_nav(object sender, EventArgs e)
        {
            this.Hide();
            tags f2 = new tags();
            f2.Show();
        }

        private void btn_locations_nav(object sender, EventArgs e)
        {
            this.Hide();
            Location f2 = new Location();
            f2.Show();
        }

        private void btn_statics_nav(object sender, EventArgs e)
        {
            this.Hide();
            Statistics f2 = new Statistics();
            f2.Show();
        }





        //------------closed,minimized,maximized,buttons---------------//

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        //--------  tag Dashboard-------//

        private void btn_addtagname(object sender, EventArgs e)
        {
            //add tag name btn

            if (addtagname.Text != "")
            {
                cmd = new SqlCommand("insert into Tag(Tagname) values(@tagname)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@tagname", addtagname.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();


            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }


        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Tag ", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();





        }




        //Clear Data  
        private void ClearData()
        {
            addtagname.Text = "";
            TagID = 0;


        }
    
        private void btn_clear(object sender, EventArgs e)
        {
            //clear btn
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data grid
        }

        private void btn_tag_editdetails(object sender, EventArgs e)
        {
            //edit details btn
        }

        private void btn_tag_delete(object sender, EventArgs e)
        {
            //delete btn
        }

        

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search by combo box
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //tagname
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //search
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void tags_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
