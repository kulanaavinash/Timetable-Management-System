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

    public partial class Homepage : Form
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


        public Homepage()
        {
            InitializeComponent();

            //---form border-----//
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;



            
            
            

        }





        //dashboard panel main
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            //----rounded buttons---//
            button15.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button15.Width, button15.Height, 30, 30));


            button16.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button16.Width, button16.Height, 30, 30));


            button17.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button17.Width, button17.Height, 30, 30));


            button18.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button18.Width, button18.Height, 30, 30));

            button19.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button19.Width, button19.Height, 30, 30));

            button20.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button20.Width, button20.Height, 30, 30));

            button21.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button21.Width, button21.Height, 30, 30));

            button22.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button22.Width, button22.Height, 30, 30));


            button23.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button23.Width, button23.Height, 30, 30));

            button24.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button24.Width, button24.Height, 30, 30));

            button25.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button25.Width, button25.Height, 30, 30));

            button26.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, button26.Width, button26.Height, 30, 30));






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
            f2.Show();                         //picturebox panel
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

        //Drag Form 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        
        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }






        //---------Homepage Dashboard buttons------//
        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            tags f2 = new tags();
            f2.Show(); 


        }

        private void button25_Click(object sender, EventArgs e)
        {

            this.Hide();
            Advanced f2 = new Advanced();
            f2.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics f2 = new Statistics();
            f2.Show(); 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaysHours f2 = new DaysHours();
            f2.Show(); 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lectures f2 = new Lectures();
            f2.Show(); 
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Hide(); students f2 = new students();
            f2.Show(); 
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location f2 = new Location();
            f2.Show(); 

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

            this.Hide();
            Room f2 = new Room();
            f2.Show(); 
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generate f2 = new Generate();
            f2.Show();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Subjects.Subjects f2 = new Subjects.Subjects();
            f2.Show();
        }
    }
}



