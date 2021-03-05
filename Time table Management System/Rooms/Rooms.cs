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

namespace Time_table_Management_System
{

    public partial class Room : Form
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


        public Room()
        {
            InitializeComponent();
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
            //picturebox panel
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //panel dashboard
        }










        //--------------Header icons------------------//
        private void btn_home_header(object sender, EventArgs e)
        {

        }

        private void btn_sessions_header(object sender, EventArgs e)
        {

        }

        private void btn_rooms_header(object sender, EventArgs e)
        {
            this.Hide();
            Room f2 = new Room();
            f2.Show(); 
        }

        private void btn_advanced_header(object sender, EventArgs e)
        {

        }

        private void btn_genarate_header(object sender, EventArgs e)
        {

        }









        //------------------Slide navbar icons....................//
        private void btn_days_nav(object sender, EventArgs e)
        {
            this.Hide();
            Room f2 = new Room ();
            f2.Show();
        }

        private void btn_lectures_nav(object sender, EventArgs e)
        {
            this.Hide();
            Room f2 = new Room();
            f2.Show();
        }

        private void btn_subjects_nav(object sender, EventArgs e)
        {
            this.Hide();     // Connected 
            Room f2 = new Room();
            f2.Show();
        }

        private void btn_students_nav(object sender, EventArgs e)
        {
            this.Hide();
            Room f2 = new Room();
            f2.Show();
        }

        private void btn_tags_nav(object sender, EventArgs e)
        {
            this.Hide();
            Room f2 = new Room();
            f2.Show();
        }

        private void btn_locations_nav(object sender, EventArgs e)
        {
            this.Hide();
            Room f2 = new Room();
            f2.Show();

        }

        private void btn_statics_nav(object sender, EventArgs e)
        {
            this.Hide();
            Room f2 = new Room();
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
    }
}
