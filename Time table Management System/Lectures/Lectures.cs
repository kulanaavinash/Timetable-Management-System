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

    public partial class Lectures : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True");

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


        public Lectures()
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

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox15_Click(object sender, EventArgs e)
        {

        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Lectures_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tabPage2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox51_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void button15_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "")
            {
                con.Open();
            SqlCommand command = new SqlCommand("insert into lecturesDB values('" + int.Parse(metroTextBox1.Text) + "','" + metroTextBox51.Text + "','" + metroComboBox3.Text + "','" + metroComboBox4.Text + "','" + metroComboBox5.Text + "','" + metroComboBox6.Text + "','" + metroComboBox7.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
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
            SqlCommand command = new SqlCommand("select * from lecturesDB", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView3.DataSource = dt;
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            BindData();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text != "")
            {
                con.Open();
            SqlCommand command = new SqlCommand("update lecturesDB set Lname ='"+ metroTextBox52.Text+ "',Lfaculty ='" + metroComboBox12.Text + "',Ldep ='" + metroComboBox11.Text + "',Lcenter ='" + metroComboBox10.Text + "',lbuild ='" + metroComboBox9.Text + "', Llevel='" + metroComboBox8.Text + "' where LID = '"+int.Parse(metroTextBox2.Text) +"'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successful Updated");
            BindData();
            }
            else
            {
                MessageBox.Show("Put Lectures ID [LID]");
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text != "")
            {
                if (MessageBox.Show("Are you sure to Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete lecturesDB where LID = '" + metroTextBox2.Text + "' ", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successful Deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Put Lectures ID [LID]");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("select Lname,Lfaculty,Ldep,Lcenter,lbuild,Llevel from lecturesDB where LID = '"+int.Parse(metroTextBox2.Text) +"'", con);
                SqlDataReader srd = command.ExecuteReader();
                while(srd.Read())
                {
                    metroTextBox52.Text = srd.GetValue(0).ToString();
                    metroComboBox12.Text = srd.GetValue(1).ToString();
                    metroComboBox11.Text = srd.GetValue(2).ToString();
                    metroComboBox10.Text = srd.GetValue(3).ToString();
                    metroComboBox9.Text = srd.GetValue(4).ToString();
                    metroComboBox8.Text = srd.GetValue(5).ToString();
                   
                }
                con.Close();


            }
            else
            {
                MessageBox.Show("Put Lectures ID [LID]");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (metroComboBox2.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from lecturesDB where LID = '" + int.Parse(metroComboBox2.Text) + "' ", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Put Lectures level");
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
