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

    public partial class Generate : Form
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


        public Generate()
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

            this.Hide();
            Homepage f2 = new Homepage();
            f2.Show();
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
            Sessions f2 = new Sessions ();
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





        //Generate Time table

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //-------view lec --tab//
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //--------View Student------ tab---//
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            //-----view classssroom---tab//
        }












        //view lectures ---generate time table
        private void label2_Click(object sender, EventArgs e)
        {
            // view lec label //
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // view lec selector
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // view lec ---view time table btn---//
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // view lec ---print timetable btn----//
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // view lec data grid view--//
        }






        //student Group ---generate time table
        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //student Group selector ---
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //student Group label
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //student Group  view time table btn
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //student Group --print timetable btn
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //student Group----data grid view
        }




        //view classroom ----gen timetable
        private void label4_Click(object sender, EventArgs e)
        {
            //view classroom  label
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //view classroom selector
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //view classroom  view timetable
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //view classroom  print timetable 
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //view classroom data grid view
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Generate_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
