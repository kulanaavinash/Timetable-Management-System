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

    public partial class Sessions : Form
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


        public Sessions () 
        {
            InitializeComponent();
            Display();
            LDisplay();
            SDisplay();
            tagDisplay();
            tagMDisplay();
            LMDisplay();
            stumDisplay();
            stuADDisplay();
            groupviewDisplay();
            subjectviewDisplay();
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
            Homepage f2 = new Homepage ();
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

        private void tabPageSessionView_Click(object sender, EventArgs e)
        {

        }

        private void b_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnSessionSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into sessionsDB values('" + int.Parse(metroTextBox1.Text) + "','" + textBox1.Text + "','" + cmbSessionTag.Text + "','" + cmbSessionGroup.Text + "','" + cmbSessionSubject.Text + "','" + nmudSessionNoStudents.Text + "','" + nmudSessionDuration.Text + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Inserted");
                con.Close();
                BindData();
            }
           /* {
                con.Open();
                SqlCommand command = new SqlCommand("insert into sessionsDB values('" + int.Parse(metroTextBox1.Text) + "','" + textBox1.Text + "','" + cmbSessionTag.Text + "','" + cmbSessionGroup.Text + "','" + cmbSessionSubject.Text + "','" + nmudSessionNoStudents.Text + "','" + nmudSessionDuration.Text + "','" + int.Parse(metroComboBox8.Text) + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");
                con.Close();
                BindData();
            }*/
            else
            {
                MessageBox.Show("Put Sessions details");
            }
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from sessionsDB", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView3.DataSource = dt;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void cmbSessionTag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSessionLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSessionGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cmbSessionSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             
            
        }

        private void nmudSessionNoStudents_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nmudSessionDuration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("update sessionsDB set lectures ='" + textBox2.Text + "',tag ='" + metroComboBox2.Text + "',Sgroup ='" + metroComboBox3.Text + "',subject ='" + metroComboBox4.Text + "',noofstudent ='" + numericUpDown1.Text + "', durations='" + numericUpDown2.Text + "' where SeID = '" + int.Parse(metroTextBox2.Text) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successful Updated");
                BindData();
            }
            else
            {
                MessageBox.Show("Put sessions ID");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text != "")
            {
                if (MessageBox.Show("Are you sure to Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete sessionsDB where SeID = '" + metroTextBox2.Text + "' ", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successful Deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Put sessions ID");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }


        private void Display()
        {
            SqlCommand command = new SqlCommand(" select subname from [dbo].[subjectsDB] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSessionSubject.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
        private void LDisplay()
        {
            SqlCommand command = new SqlCommand(" select Lname from [dbo].[lecturesDB] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSessionLecturer.Items.Add(ds.Tables[0].Rows[i][0]);
                metroComboBox5.Items.Add(ds.Tables[0].Rows[i][0]);
                metroComboBox6.Items.Add(ds.Tables[0].Rows[i][0]);
                metroComboBox7.Items.Add(ds.Tables[0].Rows[i][0]);
            }
            
        }
        private void LMDisplay()
        {
            SqlCommand command = new SqlCommand(" select Lname from [dbo].[lecturesDB] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                metroComboBox10.Items.Add(ds.Tables[0].Rows[i][0]);
                metroComboBox9.Items.Add(ds.Tables[0].Rows[i][0]);
                metroComboBox8.Items.Add(ds.Tables[0].Rows[i][0]);
                metroComboBox1.Items.Add(ds.Tables[0].Rows[i][0]);
            }

        }
        private void SDisplay()
        {
            SqlCommand command = new SqlCommand(" select subname from [dbo].[subjectsDB] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                metroComboBox4.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
        private void tagDisplay()
        {
            SqlCommand command = new SqlCommand(" select Tagname from [dbo].[Tag] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSessionTag.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
        private void tagMDisplay()
        {
            SqlCommand command = new SqlCommand(" select Tagname from [dbo].[Tag] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                metroComboBox2.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
        private void stuADDisplay()
        {
            SqlCommand command = new SqlCommand(" select GenGrpNum from [dbo].[Student] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSessionGroup.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
       
        private void stumDisplay()
        {
            SqlCommand command = new SqlCommand(" select GenGrpNum from [dbo].[Student] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                metroComboBox3.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
        private void subjectviewDisplay()
        {
            SqlCommand command = new SqlCommand(" select subject from [dbo].[sessionsDB] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSesFilterSubject.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
        
        private void groupviewDisplay()
        {
            SqlCommand command = new SqlCommand(" select Sgroup from [dbo].[sessionsDB] ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSesFilterGroup.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Sessions_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            textBox1.Text = cmbSessionLecturer.Text + ',' + metroComboBox5.Text + ',' + metroComboBox6.Text + ',' + metroComboBox7.Text;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            textBox2.Text = metroComboBox10.Text + ',' + metroComboBox9.Text + ',' + metroComboBox8.Text + ',' + metroComboBox1.Text;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("select lectures,tag,Sgroup,subject,noofstudent,durations from sessionsDB where SeID = '" + int.Parse(metroTextBox2.Text) + "'", con);
                SqlDataReader srd = command.ExecuteReader();
                while (srd.Read())
                {
                    textBox2.Text = srd.GetValue(0).ToString();
                    metroComboBox2.Text = srd.GetValue(1).ToString();
                    metroComboBox3.Text = srd.GetValue(2).ToString();
                    metroComboBox4.Text = srd.GetValue(3).ToString();
                    numericUpDown1.Text = srd.GetValue(4).ToString();
                    numericUpDown2.Text = srd.GetValue(5).ToString();
                    

                }
                con.Close();


            }
            else
            {
                MessageBox.Show("Put Enter the subjectcode [subjectcode]");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {

            if (cmbSesFilterSubject.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from sessionsDB where subject = '" + cmbSesFilterSubject.Text + "' ", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Put subject");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (cmbSesFilterGroup.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from sessionsDB where Sgroup = '" + cmbSesFilterGroup.Text + "' ", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Put Group");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
