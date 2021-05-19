using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Time_table_Management_System.DayTimeAdpt;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace Time_table_Management_System
{

    public partial class Statistics : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True");
        string cs = "Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;



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


        public Statistics ()
        {
            InitializeComponent();

            totalLecturerCount();
            totalStdGrpCount();
            totalSubjectCount();
            LoadLecFacChart();
            LoadLecDeptChart();
            LoadSgroup_programmeChart();
            Loadyear_subChart();



            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            /*chart1.Series["Faculty"].Points.AddXY("Ajay", "10000");
            chart1.Series["Faculty"].Points.AddXY("Ramesh", "8000");
            chart1.Series["Faculty"].Points.AddXY("Ankit", "7000");
            chart1.Series["Faculty"].Points.AddXY("Gurmeet", "10000");
            chart1.Series["Faculty"].Points.AddXY("Suresh", "8500"); */

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
           Generate f2 = new Generate ();
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



        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Statistics_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void total_lecturers_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void lbldept_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

       


        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
           
          

        }


        private void LoadLecFacChart()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Lfaculty,COUNT(LID) as c from lecturesDB GROUP BY Lfaculty", con);
            adapt.Fill(ds, "LecFaculty");
            chart1.DataSource = ds.Tables["LecFaculty"];

            chart1.Series["Faculty"].XValueMember = "Lfaculty";
            chart1.Series["Faculty"].YValueMembers = "c";
            chart1.Series["Faculty"].ChartType = SeriesChartType.Bar;


            chart1.DataBind();
            con.Close();

        }

        private void chart2_Click_1(object sender, EventArgs e)
        {
            

        }

        //Deparetment vs Lec count
        private void LoadLecDeptChart()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Ldep,COUNT(LID) as countlec from lecturesDB GROUP BY Ldep", con);
            adapt.Fill(ds, "countlec");
            chart2.DataSource = ds.Tables["countlec"];


            chart2.Series["Faculty"].XValueMember = "Ldep";
            chart2.Series["Faculty"].YValueMembers = "countlec";
            chart2.Series["Faculty"].ChartType = SeriesChartType.Pie;


            chart2.DataBind();
            con.Close();
        }



        private void LoadSgroup_programmeChart()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Programme,COUNT(SID) as countgrp from Student GROUP BY Programme", con);
            adapt.Fill(ds, "countgrp");
            chart3.DataSource = ds.Tables["countgrp"];


            chart3.Series["Faculty"].XValueMember = "Programme";
            chart3.Series["Faculty"].YValueMembers = "countgrp";
            chart3.Series["Faculty"].ChartType = SeriesChartType.Bar;


            chart3.DataBind();
            con.Close();
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void chart4_Click(object sender, EventArgs e)
        {
           

        }


        private void Loadyear_subChart()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select subname,COUNT(subcode) as countsub from subjectsDB GROUP BY subname", con);
            adapt.Fill(ds, "countsub");
            chart4.DataSource = ds.Tables["countsub"];


            chart4.Series["Faculty"].XValueMember = "subname";
            chart4.Series["Faculty"].YValueMembers = "countsub";
            chart4.Series["Faculty"].ChartType = SeriesChartType.Pie;


            chart4.DataBind();
            con.Close();
        }

        private void total_lecturers_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

        }


      

        private void stdgrpcount_txt_Click(object sender, EventArgs e)
        {

        }


        private void totalLecturerCount()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(LID) as lecCount FROM lecturesDB";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string lec_count = (string)dr["lecCount"].ToString();
                total_lecturers.Text = lec_count;


            }
            con.Close();

        }



        private void totalStdGrpCount()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(Sid) as grpcount FROM Student";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string grp_count = (string)dr["grpcount"].ToString();
                stdgrpcount_txt.Text = grp_count;


            }
            con.Close();

        }



        private void totalSubjectCount()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(subcode) as subCount FROM subjectsDB";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sub_count = (string)dr["subCount"].ToString();
                subject_count_txt.Text = sub_count;


            }
            con.Close();

        }
    }
}
