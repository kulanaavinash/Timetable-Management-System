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
using System.Data.SqlClient;




namespace Time_table_Management_System
{

    public partial class Statistics : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-PNIURK2S;Initial Catalog=AddLocationDB;Integrated Security=True");
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
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }


        private void Statistics_Load(object sender, EventArgs e)
        {

            totalLecturerCount();
            totalSubjectCount();
            LoadLecFacChart();
            LoadLecDeptChart();
            LoadSubjectYearChart();
            LoadProgrammeStdGroupChart();
            totalStdGrpCount();
            //LoadLecCentreChart();
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

        private void chart2_Click_1(object sender, EventArgs e)
        {

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

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

        }
         private void LoadLecFacChart()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select LecFaculty,COUNT(LecturerID) as c from Lecturers GROUP BY LecFaculty", con);
            adapt.Fill(ds, "LecFaculty");
            faclec_chart.DataSource = ds.Tables["LecFaculty"];

            faclec_chart.Series["Faculty"].XValueMember = "LecFaculty";
            faclec_chart.Series["Faculty"].YValueMembers = "c";
            //faclec_chart.Series["Faculty"].ChartType = SeriesChartType.Bar;


            faclec_chart.DataBind();
            con.Close();

        }

        private void faclec_chart_Click(object sender, EventArgs e)
        {
            
        }

        private void deptLec_chart_Click(object sender, EventArgs e)
        {

        }
        //Calculating total subject count
        private void totalStdGrpCount()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(GenGrpNum) as grpcount from GenGroupNumber group by ProgrammeRef ";
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
        private void LoadLecDeptChart()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select LecDepartment,COUNT(LecturerID) as countlec from Lecturers GROUP BY LecDepartment", con);
            adapt.Fill(ds, "countlec");
            deptLec_chart.DataSource = ds.Tables["countlec"];


            deptLec_chart.Series["Series1"].XValueMember = "LecDepartment";
            deptLec_chart.Series["Series1"].YValueMembers = "countlec";
            //deptLec_chart.Series["Series1"].ChartType = SeriesChartType.Pie;


            deptLec_chart.DataBind();
            con.Close();
        }
        //Calculating total lecturer count
        private void totalLecturerCount()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(LecturerID) as lecCount FROM Lecturers";
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

        private void LoadProgrammeStdGroupChart()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select p.Programme as Programme, count(g.GenGrpNum) as Grpcount  from Programme p, GenGroupNumber g where p.id = g.programmeRef group by p.Programme", con);
            adapt.Fill(ds, "Grpcount");
            progrpcount_chart.DataSource = ds.Tables["Grpcount"];


            progrpcount_chart.Series["Programme"].XValueMember = "Programme";
            progrpcount_chart.Series["Programme"].YValueMembers = "Grpcount";
            //progrpcount_chart.Series["Programme"].ChartType = SeriesChartType.Bar;


            progrpcount_chart.DataBind();
            con.Close();
        }

        private void LoadSubjectYearChart()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select SubYear,COUNT(SubCode) as subyrcount from Subjects GROUP BY SubYear", con);
            adapt.Fill(ds, "subyrcount");
            subyear_chart.DataSource = ds.Tables["subyrcount"];


            subyear_chart.Series["Academic Year"].XValueMember = "SubYear";
            subyear_chart.Series["Academic Year"].YValueMembers = "subyrcount";
            //subyear_chart.Series["Academic Year"].ChartType = SeriesChartType.Bar;


            subyear_chart.DataBind();
            con.Close();
        }


        //Calculating total subject count
        private void totalSubjectCount()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(SubCode) as subCount FROM Subjects";
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
