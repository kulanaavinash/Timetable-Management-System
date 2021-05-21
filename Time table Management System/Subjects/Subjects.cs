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

namespace Time_table_Management_System.Subjects
{

    public partial class Subjects : Form
    {

        SqlConnection con = new SqlConnection("Server=tcp:mysqlserveronline.database.windows.net,1433;Initial Catalog=TimetableManagementDB;Persist Security Info=False;User ID=user;Password=V41823*9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        string cs = "Server=tcp:mysqlserveronline.database.windows.net,1433;Initial Catalog=TimetableManagementDB;Persist Security Info=False;User ID=user;Password=V41823*9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


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


        public Subjects()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            BindData();//dashboard panel main
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
            Homepage  f2 = new Homepage();
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
            Subjects f2 = new Subjects ();
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Subjects_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       


        private void button19_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into subjectsDB values('" + int.Parse(metroTextBox2.Text) + "','" + metroTextBox1.Text + "','" + int.Parse(metroComboBox3.Text) + "','" + metroComboBox4.Text + "','" + int.Parse(metroComboBox5.Text) + "','" + int.Parse(metroComboBox6.Text) + "','" + int.Parse(metroComboBox7.Text) + "','" + int.Parse(metroComboBox8.Text) + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");
                con.Close();
                BindData();
            }
            else
            {
                MessageBox.Show("Put Lectures details");
            }
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from subjectsDB", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView3.DataSource = dt;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (metroTextBox3.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("update subjectsDB set subname ='" + metroTextBox4.Text + "',ofdyear ='" + metroComboBox2.Text + "',ofdsemester ='" + metroComboBox13.Text + "',nooflectures ='" + metroComboBox12.Text + "',nooftutorial ='" + metroComboBox11.Text + "', noofhours='" + metroComboBox10.Text + "', noofeve='" + metroComboBox9.Text + "' where subcode = '" + int.Parse(metroTextBox3.Text) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successful Updated");
                BindData();
            }
            else
            {
                MessageBox.Show("Put students code [LID]");
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (metroTextBox3.Text != "")
            {
                if (MessageBox.Show("Are you sure to Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete subjectsDB where subcode = '" + metroTextBox3.Text + "' ", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successful Deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Put subjects code [subcode]");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (metroTextBox3.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("select subname,ofdyear,ofdsemester,nooflectures,nooftutorial,noofhours,noofeve from subjectsDB where subcode = '" + int.Parse(metroTextBox3.Text) + "'", con);
                SqlDataReader srd = command.ExecuteReader();
                while (srd.Read())
                {
                    metroTextBox4.Text = srd.GetValue(0).ToString();
                    metroComboBox2.Text = srd.GetValue(1).ToString();
                    metroComboBox13.Text = srd.GetValue(2).ToString();
                    metroComboBox12.Text = srd.GetValue(3).ToString();
                    metroComboBox11.Text = srd.GetValue(4).ToString();
                    metroComboBox10.Text = srd.GetValue(5).ToString();
                    metroComboBox9.Text = srd.GetValue(6).ToString();

                }
                con.Close();


            }
            else
            {
                MessageBox.Show(" Enter the subjectcode to doing changes.. [subjectcode]");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from subjectsDB where ofdyear = '" + int.Parse(metroComboBox1.Text) + "' ", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Put offered year [ofdyear]");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
