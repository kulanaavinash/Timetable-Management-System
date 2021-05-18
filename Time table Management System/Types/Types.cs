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

    public partial class Advanced : Form
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


        public Advanced()
        {
            InitializeComponent();
            DisplayData();
            BindData();
            SaveData();
            Catch();
            Catch2();
            ShowData();
            Show1();
            Show2();

            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
        }

        NotAvailableTime a = new NotAvailableTime();




        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dashboard panel main
            DataTable dt4 = a.Select();
            NotAvialbleView.DataSource = dt4;

            //Change  Column header in Not Availeble time
            NotAvialbleView.Columns["NATno"].HeaderText = "NAT NO";
            NotAvialbleView.Columns["stype"].HeaderText = "TYPE";
            NotAvialbleView.Columns["sitems"].HeaderText = "ITEM";
            NotAvialbleView.Columns["stime"].HeaderText = "Start Time";
            NotAvialbleView.Columns["etime"].HeaderText = "End Time";
            NotAvialbleView.Columns["date"].HeaderText = "DATE";

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
            f2.Show(); ;
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











        //consective sessions ---Advanced-----//


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //consective sessions
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //consective sessions select session 01                    
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //consective sessions select session 02
        }


        private void button16_Click(object sender, EventArgs e)
        {
            //consective sessions
            ClearData();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //consective sessions
            if ((comboBox6.Text != string.Empty) && (comboBox7.Text != string.Empty))
            {
                cmd = new SqlCommand("insert into Consecutive(Session01,Session02) values(@session01,@session02)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@session01", comboBox6.Text);
                cmd.Parameters.AddWithValue("@session02", comboBox7.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Consecutive Session Record Successfully");
                BindData();
                ClearData();

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void BindData()
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select Session01,Session02 from Consecutive ", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();





            }


        private void ClearData()
        {
            comboBox6.Text = "";
            comboBox7.Text = "";

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox8.Text = "";


            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            comboBox12.Text = "";
            comboBox13.Text = "";
            comboBox14.Text = "";


        }

        

            private void DisplayData()
        {
            SqlCommand sqlComm = new SqlCommand("select subject,lectures,tag from [dbo].[sessionsDB]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox6.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);
                comboBox7.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);
            }

        }

        


        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            //consective sessions
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //consective sessions
        }



        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //consective sessions
        }


        private void label2_Click(object sender, EventArgs e)
        {
            //consective sessions ---label
        }








        //Parellel Sessions ---Advancedd---//

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void metroComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions

        }

        private void metroComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Parellel Sessions

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //Parellel Sessions

        }
        private void button17_Click(object sender, EventArgs e)
        {
            //Parellel Sessions
            //consective sessions
            if ((comboBox1.Text != string.Empty) && (comboBox2.Text != string.Empty) && (comboBox3.Text != string.Empty) && (comboBox4.Text != string.Empty) && (comboBox5.Text != string.Empty) && (comboBox8.Text != string.Empty))
            {
                cmd = new SqlCommand("insert into Parallel(Session01,Session02,Duration,Day,Stime,Etime) values(@session01,@session02,@duration,@day,@stime,@etime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@session01", comboBox1.Text);
                cmd.Parameters.AddWithValue("@session02", comboBox2.Text);
                cmd.Parameters.AddWithValue("@duration", comboBox3.Text);
                cmd.Parameters.AddWithValue("@day", comboBox4.Text);
                cmd.Parameters.AddWithValue("@stime", comboBox5.Text);
                cmd.Parameters.AddWithValue("@etime", comboBox8.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Consecutive Session Record Successfully");
                ClearData();


            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //parallel sessions
        private void SaveData()
        {
            SqlCommand sqlComm = new SqlCommand("select subject,lectures,tag from [dbo].[sessionsDB]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);
                comboBox2.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);

            }

        }

        private void Catch()
        {
            SqlCommand sqlComm = new SqlCommand("select stime from [dbo].[NAT]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox5.Items.Add(ds.Tables[0].Rows[i][0]  );
                
            }

        }


        private void Catch2()
        {
            SqlCommand sqlComm = new SqlCommand("select etime from [dbo].[NAT]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox8.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Parellel Sessions

            ClearData();
           

        }













        // not overlap Sessions---Advanced//
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

            // not overlap Sessions-

        }

        private void metroComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }










        //not avialble time tab


        private void metroComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            //not avialble time
        }

        private void metroComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            //not avialble time
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //not avialble time
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //not avialble time
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //not avialble time
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //not avialble time
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //not avialble time
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //not avialble time
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //not avialble time
            //get data from databse tab
            a.NATno = Convert.ToInt32(NATno.Text);

            bool success = a.Delete(a);
            if (success == true)
            {
                MessageBox.Show("Success to delete this week");
                //refreash
                DataTable dt5 = a.Select();
                NotAvialbleView.DataSource = dt5;
            }
            else
            {
                MessageBox.Show("Failed delete");
            }
        }


        private void Clear()
        {
            
            // After data clear not avialbe details tab

            stype.Text = "Select type";
            sitems.Text = "select Item";
            stime.Text = "Start time";
            etime.Text = "End time";
            date.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //not avialble time
            //get values from the input field
            a.stype = stype.Text;
            a.sitems = sitems.Text;
            a.stime = stime.Text;
            a.etime = etime.Text;
            a.date = date.Text;


            //insert into data in database using the method
            bool success = a.Insert(a);
            if (success == true)
            {
                //successfully insert
                MessageBox.Show("Not Avialble Time added");
                Clear();

            }
            else
            {
                //faild to add session
                MessageBox.Show("Failed to add Not Avialble Time try again");
            }
            DataTable dt5 = a.Select();
            NotAvialbleView.DataSource = dt5;
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string keyword = NATsearch.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM NAT WHERE NATno LIKE '%" + keyword + "%' OR stype LIKE '%" + keyword + "%' OR sitems LIKE '%" + keyword + "%'", conn);
            DataTable dt5 = new DataTable();
            sda.Fill(dt5);
            NotAvialbleView.DataSource = dt5;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Advanced_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void NotAvialbleView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            NATno.Text = NotAvialbleView.Rows[rowIndex].Cells[0].Value.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //add not overlap sessions

            if ((comboBox9.Text != string.Empty) && (comboBox10.Text != string.Empty) && (comboBox11.Text != string.Empty) && (comboBox12.Text != string.Empty) && (comboBox13.Text != string.Empty) && (comboBox14.Text != string.Empty))
            {
                cmd = new SqlCommand("insert into Overlap(Session01,Session02,Duration,Day,Stime,Etime) values(@session01,@session02,@duration,@day,@stime,@etime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@session01", comboBox9.Text);
                cmd.Parameters.AddWithValue("@session02", comboBox10.Text);
                cmd.Parameters.AddWithValue("@duration", comboBox11.Text);
                cmd.Parameters.AddWithValue("@day", comboBox12.Text);
                cmd.Parameters.AddWithValue("@stime", comboBox13.Text);
                cmd.Parameters.AddWithValue("@etime", comboBox14.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Consecutive Session Record Successfully");
                ClearData();


            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
    }

        private void ShowData()
        {
            SqlCommand sqlComm = new SqlCommand("select subject,lectures,tag from [dbo].[sessionsDB]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox9.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1] + " | " + ds.Tables[0].Rows[i][2]);
                comboBox10.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1] + " | " + ds.Tables[0].Rows[i][2]);
            }

        }

        private void Show1()
        {
            SqlCommand sqlComm = new SqlCommand("select stime from [dbo].[NAT]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox13.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }


        private void Show2()
        {
            SqlCommand sqlComm = new SqlCommand("select etime from [dbo].[NAT]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox14.Items.Add(ds.Tables[0].Rows[i][0]);

            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
