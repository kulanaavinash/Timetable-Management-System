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

    public partial class students : Form
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


        public students()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
           
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

        }

        private void btn_lectures_nav(object sender, EventArgs e)
        {

        }

        private void btn_subjects_nav(object sender, EventArgs e)
        {

        }

        private void btn_students_nav(object sender, EventArgs e)
        {

        }

        private void btn_tags_nav(object sender, EventArgs e)
        {

        }

        private void btn_locations_nav(object sender, EventArgs e)
        {

        }

        private void btn_statics_nav(object sender, EventArgs e)
        {

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









        //-----nav Bar ----metro panel--//


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }










        //--year sem_dashboard---//

        private void y_sem_year(object sender, EventArgs e)
        {
            //yaer text box
        }

        private void y_sem_semester(object sender, EventArgs e)
        {
            //semester text box
        }

        private void y_sem_add_y_sem_btn(object sender, EventArgs e)
        {
            //btn add year semester
        }

        private void y_sem_clear_btn(object sender, EventArgs e)
        {
            //btn clear y-sem
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search by y-sem
        }

        private void y_sem_search(object sender, EventArgs e)
        {
            //search y_sem
        }

        private void y_sem_btn_Edit_details(object sender, EventArgs e)
        {
            //y_sem_nt edit details
        }

        private void y_sem_btn_delete(object sender, EventArgs e)
        {
            //y_sem_btn_delete
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //y sem data grid view
        }











        //--programme dashboard//

        private void txtbox_programme(object sender, EventArgs e)
        {
            //txt box programme
        }

        private void btn_programme_clean(object sender, EventArgs e)
        {
            //btn clean
        }

        private void btn_addprogramme(object sender, EventArgs e)
        {
            //btn add programme
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //programme_serach by
        }

        private void programme_search(object sender, EventArgs e)
        {
            //programe search
        }

        private void bt_programme_Editdetails(object sender, EventArgs e)
        {
            //programmee btn edit details
        }

        private void btn_delete_btn(object sender, EventArgs e)
        {
            //btn_delete_btn
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //programme grid view
        }







        // group member dahsboard//

        private void g_mem_group_member(object sender, EventArgs e)
        {
            //txt box group number
        }

        private void btn_add_groupnum(object sender, EventArgs e)
        {
            //btn_add group num
        }

        private void grp_num_btn_clear(object sender, EventArgs e)
        {
            //btn_clear 
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //serach by group num
        }

        private void searcg_g_num(object sender, EventArgs e)
        {
            //search g num
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid view search
        }

        private void bt_g_num_delete(object sender, EventArgs e)
        {
            //btn delete
        }

        private void btn_g_num_editdetails(object sender, EventArgs e)
        {
            //btn edit details
        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {
            //txt box sub group number
        }











        //sub group dashboard//
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //sub group grid view
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            //btn add sub group num
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            //btn clear sub group
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
           //  edit details sub group
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search  by sub group
        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {
            //search btn sub group
        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {
            //txt box sub group  number
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            //btn delete sub group
        }







        //generate group ID s dashboard//

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //dtata grid view left
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //serach by 
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data grid view right
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            //generate group id btn
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            //confirm and add btn
        }

        private void metroTextBox11_Click(object sender, EventArgs e)
        {
            //search 
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            //delete
        }





        //Generate sub group ID------dashboard//
        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //left grid view
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //right grid view
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            //delete btn
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {
            //confirm and add btn
        }

        private void metroButton17_Click_1(object sender, EventArgs e)
        {
            //gen sub group id btn
        }





        //-----view details dahsboard---//
        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search by
        }

        private void metroTextBox12_Click(object sender, EventArgs e)
        {
            //search
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data grid view
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void students_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
