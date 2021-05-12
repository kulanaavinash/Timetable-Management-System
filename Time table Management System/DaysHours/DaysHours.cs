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
using System.Configuration;
using System.Data.SqlClient;

namespace Time_table_Management_System
{

    public partial class DaysHours : Form
    {
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


        public DaysHours()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
            //Form
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }

        DayTimeClass c = new DayTimeClass();
        NbDays n = new NbDays();
        TimeDay t = new TimeDay();
        TimeSlot s = new TimeSlot();



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dashboard panel nb days per week
            DataTable dt = n.Select();
            NbWorkdayView.DataSource = dt;

            //time and date views
            DataTable dt1 = t.Select();
            daytimeview.DataSource = dt1;

            //Time slot
            DataTable dt2 = s.Select();
            timeslotview.DataSource = dt2;

            //change time slot column header
            timeslotview.Columns["timeSlotNo"].HeaderText = "Slot No";
            timeslotview.Columns["datepicker"].HeaderText = "Date";
            timeslotview.Columns["start_time"].HeaderText = "Start Time";
            timeslotview.Columns["end_time"].HeaderText = "End Time";

            // change column header in nbdays view
            NbWorkdayView.Columns["week"].HeaderText = "Week No";
            NbWorkdayView.Columns["days"].HeaderText = "Days";


            //Change  Column header in time day view
            daytimeview.Columns["timeday"].HeaderText = "Week No ";
            daytimeview.Columns["time1"].HeaderText = "Hour";
            daytimeview.Columns["time2"].HeaderText = "Hour";
            daytimeview.Columns["time3"].HeaderText = "Hour";
            daytimeview.Columns["time4"].HeaderText = "Hour";
            daytimeview.Columns["time5"].HeaderText = "Hour";
            daytimeview.Columns["time6"].HeaderText = "Hour";
            daytimeview.Columns["time7"].HeaderText = "Hour";
            daytimeview.Columns["day1"].HeaderText = "Day 1";
            daytimeview.Columns["day2"].HeaderText = "Day 2";
            daytimeview.Columns["day3"].HeaderText = "Day 3";
            daytimeview.Columns["day4"].HeaderText = "Day 4";
            daytimeview.Columns["day5"].HeaderText = "Day 5";
            daytimeview.Columns["day6"].HeaderText = "Day 6";
            daytimeview.Columns["day7"].HeaderText = "Day 7";

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
            f2.Show();   //picturebox panel
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void DaysHours_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //get values from the input field
            c.faculty = faculty.Text;
            c.lecture = lecture.Text;
            c.session_type = session_type.SelectedIndex;
            c.date = date.Text;
            c.class_room = class_room.Text;
            c.department = department.Text;
            c.session = session.Text;
            c.center = center.Text;

            //insert into data in database using the method
            bool success = c.Insert(c);
            if (success == true)
            {
                //successfully insert
                MessageBox.Show("New sission added");

                Clear();
            }
            else
            {
                //faild to add session
                MessageBox.Show("Failed to add New session try again");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //get values from the input field
            t.timeday = timeday.Text.Length;
            t.day1 = d1.Text;
            t.time1 = (int)hour1.Value;
            t.day2 = d2.Text;
            t.time2 = (int)hour2.Value;
            t.day3 = d3.Text;
            t.time3 = (int)hour3.Value;
            t.day4 = d4.Text;
            t.time4 = (int)hour4.Value;
            t.day5 = d5.Text;
            t.time5 = (int)hour5.Value;
            t.day6 = d6.Text;
            t.time6 = (int)hour6.Value;
            t.day7 = d7.Text;
            t.time7 = (int)hour7.Value;


            //insert into data in database using the method
            bool success = t.Insert(t);
            if (success == true)
            {
                //successfully insert
                MessageBox.Show("New working days and time added");
                Clear();
            }
            else
            {
                //faild to add session
                MessageBox.Show("Failed to add New working days and time try again");
            }
            DataTable dt1 = t.Select();
            daytimeview.DataSource = dt1;

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void NDdays_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NbWorkdayView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NbWorkdayView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            //get values from the input field
            s.datepicker = datepicker.Text;
            s.start_time = start_time.Text;
            s.end_time = end_time.Text;


            //insert into data in database using the method
            bool success = s.Insert(s);
            if (success == true)
            {
                //successfully insert
                MessageBox.Show("New Slot added");
            }
            else
            {
                //faild to add session
                MessageBox.Show("Failed to add New Slot try again");
            }
            DataTable dt2 = s.Select();
            timeslotview.DataSource = dt2;
        }

        private void button19_Click_2(object sender, EventArgs e)
        {
            //get values from the input field
            n.days = (int)NDdays.Value;


            //insert into data in database using the method
            bool success = n.Insert(n);
            if (success == true)
            {
                //successfully insert
                MessageBox.Show("New working days and time added");
                Clear();
            }
            else
            {
                //faild to add session
                MessageBox.Show("Failed to add New working days and time try again");
            }
            DataTable dt = n.Select();
            NbWorkdayView.DataSource = dt; ;
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clear()
        {
            //after clear data daytime tab
            timeday.Text = "";
            d1.Text = "";
            hour1.Value = 0;
            d2.Text = "";
            hour2.Value = 0;
            d3.Text = "";
            hour3.Value = 0;
            d4.Text = "";
            hour4.Value = 0;
            d5.Text = "";
            hour5.Value = 0;
            d6.Text = "";
            hour6.Value = 0;
            d7.Text = "";
            hour7.Value = 0;

            // After data clear add session tab

            faculty.Text = "";
            lecture.Text = "";
            session_type.Text = "";
            date.Text = "";
            class_room.Text = "";
            department.Text = "";
            session.Text = "";
            center.Text = "";

            //After data clear in working days

            NDdays.Value = 0;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            //get the data from textboxes
            t.timeday = int.Parse(timeday.Text);
            t.day1 = d1.Text;
            t.time1 = int.Parse(hour1.Text);
            t.day2 = d2.Text;
            t.time2 = int.Parse(hour2.Text);
            t.day3 = d3.Text;
            t.time3 = int.Parse(hour3.Text);
            t.day4 = d4.Text;
            t.time4 = int.Parse(hour4.Text);
            t.day5 = d5.Text;
            t.time5 = int.Parse(hour5.Text);
            t.day6 = d6.Text;
            t.time6 = int.Parse(hour6.Text);
            t.day7 = d7.Text;
            t.time7 = int.Parse(hour7.Text);

            //Update Data in database
            bool success = t.Update(t);
            if (success = true)
            {
                //successfull mg
                MessageBox.Show("Days and Time Successfully Update");
                //refesh
                DataTable dt = t.Select();
                daytimeview.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Days and Time Failed Update.Try again.  ");
            }
        }

        private void daytimeview_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            timeday.Text = daytimeview.Rows[rowIndex].Cells[0].Value.ToString();
            d1.Text = daytimeview.Rows[rowIndex].Cells[1].Value.ToString();
            hour1.Text = daytimeview.Rows[rowIndex].Cells[2].Value.ToString();
            d2.Text = daytimeview.Rows[rowIndex].Cells[3].Value.ToString();
            hour2.Text = daytimeview.Rows[rowIndex].Cells[4].Value.ToString();
            d3.Text = daytimeview.Rows[rowIndex].Cells[5].Value.ToString();
            hour3.Text = daytimeview.Rows[rowIndex].Cells[6].Value.ToString();
            d4.Text = daytimeview.Rows[rowIndex].Cells[7].Value.ToString();
            hour4.Text = daytimeview.Rows[rowIndex].Cells[8].Value.ToString();
            d5.Text = daytimeview.Rows[rowIndex].Cells[9].Value.ToString();
            hour5.Text = daytimeview.Rows[rowIndex].Cells[10].Value.ToString();
            d6.Text = daytimeview.Rows[rowIndex].Cells[11].Value.ToString();
            hour6.Text = daytimeview.Rows[rowIndex].Cells[12].Value.ToString();
            d7.Text = daytimeview.Rows[rowIndex].Cells[13].Value.ToString();
            hour7.Text = daytimeview.Rows[rowIndex].Cells[14].Value.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //call clear Method here
            Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //get data from databse tab
            t.timeday = Convert.ToInt32(timeday.Text);
            bool success = t.Delete(t);
            if (success == true)
            {
                MessageBox.Show("Success to delete this week");
                //refreash
                DataTable dt = t.Select();
                daytimeview.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed delete");
            }

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void button22_Click_2(object sender, EventArgs e)
        {
            n.week = int.Parse(week.Text);
            n.days = (int)NDdays.Value;

            bool success = n.Update(n);
            if (success = true)
            {
                //successfull mg
                MessageBox.Show("Days Successfully Update");
                //refesh
                DataTable dt = n.Select();
                NbWorkdayView.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Days Failed Update.Try again.  ");
            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            //get data from databse tab
            n.week = Convert.ToInt32(week.Text);

            bool success = n.Delete(n);
            if (success == true)
            {
                MessageBox.Show("Success to delete this week");
                //refreash
                DataTable dt = n.Select();
                NbWorkdayView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed delete");
            }
        }

        private void NbWorkdayView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            week.Text = NbWorkdayView.Rows[rowIndex].Cells[0].Value.ToString();
            NDdays.Text = NbWorkdayView.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void time_Click(object sender, EventArgs e)
        {
            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timeslotview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void Nbsearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from text box
            string keyword = Nbsearch.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM NbDays WHERE week LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            NbWorkdayView.DataSource = dt;
        }

        private void DayTimeSearch_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = DayTimeSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM day_time WHERE timeday LIKE '%" + keyword + "%'", conn);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            daytimeview.DataSource = dt1;
        }

        private void SlotSearch_TextChanged(object sender, EventArgs e)
        {

            string keyword = SlotSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Time_slots WHERE timeSlotNo LIKE '%" + keyword + "%' OR datepicker LIKE '%" + keyword + "%' OR start_time LIKE '%" + keyword + "%'", conn);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            timeslotview.DataSource = dt2;
        }

        private void week_TextChanged(object sender, EventArgs e)
        {

        }

        private void week_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void timeslotview_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void label12_Click_2(object sender, EventArgs e)
        {

        }

        private void daytimeview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NDdays_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
