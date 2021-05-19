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

namespace Time_table_Management_System
{

    public partial class Room : Form
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


        public Room()
        {
            InitializeComponent();
            ShowData();
            Data();
            View();
            See();
            See1();
            Data1();
            ShowData1();
            See2();
            Data3();
            View3();
            Data4();


            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
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
            Homepage f2 = new Homepage ();
            f2.Show();  //picturebox panel
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
            Sessions f2 = new Sessions  ();
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
            DaysHours f2 = new DaysHours ();
            f2.Show();
        }

        private void btn_lectures_nav(object sender, EventArgs e)
        {
            this.Hide();
            Lectures f2 = new Lectures ();
            f2.Show();
        }

        private void btn_subjects_nav(object sender, EventArgs e)
        {
            this.Hide();     // Connected 
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

        private void clear_tag_btn_Click(object sender, EventArgs e)
        {

        }

        private void allocate_tag_btn_Click(object sender, EventArgs e)
        {

        }

        private void tagroom_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void tag_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void tagsub_room_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void clrtagsub_btn_Click(object sender, EventArgs e)
        {

        }

        private void allocatetagsub_btn_Click(object sender, EventArgs e)
        {

        }

        private void tagsub_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void sub_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void clrLecturerroom_btn_Click(object sender, EventArgs e)
        {

        }

        private void allocatelecturer_room_btn_Click(object sender, EventArgs e)
        {

        }

        private void lecroom_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void lecturer_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void grproom_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void clr_grp_btn_Click(object sender, EventArgs e)
        {

        }

        private void grpallocateroom_btn_Click(object sender, EventArgs e)
        {

        }

        private void subgrp_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void grp_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void clr_session_btn_Click(object sender, EventArgs e)
        {

        }

        private void allocatesession_room_btn_Click(object sender, EventArgs e)
        {

        }

        private void session_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void session_room_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void clr_consec_btn_Click(object sender, EventArgs e)
        {

        }

        private void allocateroomconsecsession_btn_Click(object sender, EventArgs e)
        {

        }

        private void consec_room_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void session1_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void non_res_room_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void non_reserv_room_time_btn_Click(object sender, EventArgs e)
        {

        }

        private void clrnonreserve_btn_Click(object sender, EventArgs e)
        {

        }

        private void timeslot_cmb_DropDown(object sender, EventArgs e)
        {

        }

        private void consec_session_lbl_Click(object sender, EventArgs e)
        {

        }

        private void addrooms_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tag_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tag_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void room_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tagroom_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allocate_tag_btn_Click_1(object sender, EventArgs e)
        {

            if ((tag_cmb.Text != string.Empty) && (tagroom_cmb.Text != string.Empty))
            {
                //check duplicate before save
                SqlDataAdapter da = new SqlDataAdapter("Select tagname, roomid from room_tag where tagname = '" + tag_cmb.Text + "' and  roomid = '" + tagroom_cmb.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The room is already allocated for the selected lecturer");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[room_tag] ([tagname],[roomid]) VALUES ('" + tag_cmb.Text + "','" + tagroom_cmb.Text + "' )";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Allocated!");
                    con.Close();

                }

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowData1()
        {
            SqlCommand sqlComm = new SqlCommand("select Tagname from [dbo].[Tag]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                tag_cmb.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }


        private void Data1()
        {
            SqlCommand sqlComm = new SqlCommand("select room from [dbo].[Locations]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                tagroom_cmb.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }




        private void clear_tag_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tagsub_lbl_Click(object sender, EventArgs e)
        {

        }

        private void sub_lbl_Click(object sender, EventArgs e)
        {

        }

        private void sub_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tag_sub_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tagsub_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tagsub_room_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tagsub_room_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allocatetagsub_btn_Click_1(object sender, EventArgs e)
        {
            if ((sub_cmb.Text != string.Empty) && (tagsub_room_cmb.Text != string.Empty))
            {
                //check duplicate before save
                SqlDataAdapter da = new SqlDataAdapter("Select sub_tag, roomid from room_subtag where sub_tag = '" + sub_cmb.Text + "' and  roomid = '" + tagsub_room_cmb.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The room is already allocated for the selected lecturer");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[room_subtag] ([sub_tag],[roomid]) VALUES ('" + sub_cmb.Text + "','" + tagsub_room_cmb.Text + "' )";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Allocated!");
                    con.Close();

                }

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void View3()
        {
            SqlCommand sqlComm = new SqlCommand("select tag,subject from [dbo].[sessionsDB]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sub_cmb.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1]);

            }

        }




        private void Data4()
        {
            SqlCommand sqlComm = new SqlCommand("select room from [dbo].[Locations]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                tagsub_room_cmb.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }

        private void clrtagsub_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void lec_lbl_Click(object sender, EventArgs e)
        {

        }

        private void lecturer_lbl_Click(object sender, EventArgs e)
        {

        }

        private void lecturer_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lecroom_lbl_Click(object sender, EventArgs e)
        {

        }

        private void lecroom_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allocatelecturer_room_btn_Click_1(object sender, EventArgs e)
        {   
            if ((lecturer_cmb.Text != string.Empty) && (lecroom_cmb.Text != string.Empty))
            {
                //check duplicate before save
                SqlDataAdapter da = new SqlDataAdapter("Select Lecturer, roomid from room_lec where Lecturer = '" + lecturer_cmb.Text + "' and  roomid = '" + lecroom_cmb.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The room is already allocated for the selected lecturer");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[room_lec] ([Lecturer],[roomid]) VALUES ('" + lecturer_cmb.Text + "','" + lecroom_cmb.Text + "' )";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Allocated!");
                    con.Close();
                    
                }

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //load lecture method
        private void ShowData()
        {
            SqlCommand sqlComm = new SqlCommand("select Lname from [dbo].[lecturesDB]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lecturer_cmb.Items.Add(ds.Tables[0].Rows[i][0]);
                
            }

        }


        private void Data()
        {
            SqlCommand sqlComm = new SqlCommand("select room from [dbo].[Locations]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lecroom_cmb.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }


        private void clrLecturerroom_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void grpsubgrp_lbl_Click(object sender, EventArgs e)
        {

        }

        private void grp_lbl_Click(object sender, EventArgs e)
        {

        }

        private void grp_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subgrp_lbl_Click(object sender, EventArgs e)
        {

        }

        private void subgrp_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grproom_lbl_Click(object sender, EventArgs e)
        {

        }

        private void grproom_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpallocateroom_btn_Click_1(object sender, EventArgs e)
        {
            if ((grp_cmb.Text != string.Empty) && (subgrp_cmb.Text != string.Empty) && (grproom_cmb.Text != string.Empty))
            {
                //check duplicate before save
                SqlDataAdapter da = new SqlDataAdapter("Select groupnum, subgroup, roomid from room_group" +
                    " where groupnum = '" + grp_cmb.Text + "' and  subgroup = '" + subgrp_cmb.Text + "'and  roomid = '" + grproom_cmb.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The room is already allocated for the selected group and sub group!");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[room_group] ([groupnum],[subgroup],[roomid]) " +
                        "VALUES ('" + grp_cmb.Text + "','" + subgrp_cmb.Text + "','" + grproom_cmb.Text + "'  )";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Allocated Successfully!");
                    con.Close();
                   
                }

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void View()
        {
            SqlCommand sqlComm = new SqlCommand("select Room from [dbo].[Locations]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                grproom_cmb.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }



        private void See()
        {
            SqlCommand sqlComm = new SqlCommand("select GenSubGrpNum from [dbo].[Student]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                subgrp_cmb.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }


        private void See1()
        {
            SqlCommand sqlComm = new SqlCommand("select GenGrpNum from [dbo].[Student]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                grp_cmb.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }



        private void clr_grp_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void session_lbl_Click(object sender, EventArgs e)
        {

        }

        private void session_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void session_room_lbl_Click(object sender, EventArgs e)
        {

        }

        private void session_room_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allocatesession_room_btn_Click_1(object sender, EventArgs e)
        {

            if ((session_cmb.Text != string.Empty) && (session_room_cmb.Text != string.Empty))
            {
                //check duplicate before save
                SqlDataAdapter da = new SqlDataAdapter("Select sessions, roomid from room_sessions where sessions = '" + session_cmb.Text + "' and  roomid = '" + session_room_cmb.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("The room is already allocated for the selected lecturer");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[room_sessions] ([sessions],[roomid]) VALUES ('" + session_cmb.Text + "','" + session_room_cmb.Text + "' )";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Allocated!");
                    con.Close();

                }

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void See2()
        {
            SqlCommand sqlComm = new SqlCommand("select lectures,tag,Sgroup,subject,noofstudent,durations from [dbo].[sessionsDB]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                session_cmb.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2] + " |" + ds.Tables[0].Rows[i][3] + " |" + ds.Tables[0].Rows[i][4] + " |" + ds.Tables[0].Rows[i][5]);
            }

        }


        private void Data3()
        {
            SqlCommand sqlComm = new SqlCommand("select room from [dbo].[Locations]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                session_room_cmb.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }


       

        private void clr_session_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void con_session_room_lbl_Click(object sender, EventArgs e)
        {

        }

        private void consec_room_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void session1_lbl_Click(object sender, EventArgs e)
        {

        }

        private void session1_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allocateroomconsecsession_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void clr_consec_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void non_reservable_lbl_Click(object sender, EventArgs e)
        {

        }

        private void nonreser_room_lbl_Click(object sender, EventArgs e)
        {

        }

        private void non_res_room_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nonreser_time_lbl_Click(object sender, EventArgs e)
        {

        }

        private void day_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void starttime_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void endtime_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void non_reserv_room_time_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void clrnonreserve_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void metroPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        //Drag Form 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Room_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void sessionheading_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
