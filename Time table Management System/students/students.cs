using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;

namespace Time_table_Management_System
{

    public partial class students : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True");
        string cs = "Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;



        //ID variable used in Updating and Deleting Record  
        int YearSemID = 0;
        int ProgrammeID = 0;
        int GroupID = 0;
        int SubGroupID = 0;
        int Sid = 0;
        
        


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
            DisplayData();
            BindData();
            ViewData();
            SeeData();

            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

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
            Advanced f2 = new Advanced ();
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

            if (yeartxt.Text != "" && semtxt.Text != "")
            {
                cmd = new SqlCommand("insert into Student(Year,Semester) values(@year,@semester)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@year", yeartxt.Text);
                cmd.Parameters.AddWithValue("@semester", semtxt.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();


            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }



        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Sid,Year,Semester from Student", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();





        }




        //Clear Data  
        private void ClearData()
        {
            yeartxt.Text = "";
            semtxt.Text = "";
            programtxt.Text = "";
            addgroupnumtxt.Text = "";







        }


    

    private void y_sem_clear_btn(object sender, EventArgs e)
        {
            //btn clear y-sem

            ClearData();
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

            if (yeartxt.Text != "" && semtxt.Text != "")
            {
                cmd = new SqlCommand("update Student set Year=@year,Semester=@semester where Sid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Sid);
                cmd.Parameters.AddWithValue("@year", yeartxt.Text);
                cmd.Parameters.AddWithValue("@semester", semtxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }

        }

        private void y_sem_btn_delete(object sender, EventArgs e)
        {
            //y_sem_btn_delete


            if (YearSemID != 0)
            {
                cmd = new SqlCommand("delete YearSemester where YearSemID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", YearSemID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //y sem data grid view

            DisplayData();
        }











        //--programme dashboard//

        private void txtbox_programme(object sender, EventArgs e)
        {
            //txt box programme
        }

        private void btn_programme_clean(object sender, EventArgs e)
        {
            //btn clean
            ClearData();
        }

        private void btn_addprogramme(object sender, EventArgs e)
        {
            /* //btn add programme
             if (programtxt.Text != "")
             {
                 cmd = new SqlCommand("insert into Programmestudent(Programme) values(@programme)", con);
                 con.Open();
                 cmd.Parameters.AddWithValue("@programme", programtxt.Text);

                 cmd.ExecuteNonQuery();
                 con.Close();
                 MessageBox.Show("Record Inserted Successfully");
                 BindData();
                 ClearData();


             }
             else
             {
                 MessageBox.Show("Please Provide Details!");
             }


         */

        }


        //Display Data in DataGridView  programme
        private void BindData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Sid,Programme from Student ", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();





        }




        //Clear Data  
        private void ResetData()
        {
            programtxt.Text = "";
            ProgrammeID = 0;





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


       
            
                cmd = new SqlCommand("update Student set Programme=@programme  where Sid=@id", con);
               
                cmd.Parameters.AddWithValue("@id", Sid);
                cmd.Parameters.AddWithValue("@programme", programtxt.Text);
                 con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Programme Details Added Successfully");
                con.Close();
                BindData();
                DisplayData();
                ClearData();
            
            

        }

        private void btn_delete_btn(object sender, EventArgs e)
        {
            //btn_delete_btn
/*
            if (ProgrammeID != 0)
            {
                cmd = new SqlCommand("delete programmestudent where ProgrammeID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ProgrammeID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                BindData();
                ResetData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
*/

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

            //btn add programme
           /* if (addgroupnumtxt.Text != "")
            {
                cmd = new SqlCommand("insert into GroupNumber(Groupnumber) values(@groupnumber)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@groupnumber", addgroupnumtxt.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                ViewData();
                CloseData();


            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }*/
        }

        //Display Data in DataGridView  
        private void ViewData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Sid,GrpNumber from Student ", con);
            adapt.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();





        }




        //Clear Data  
        private void CloseData()
        {
            addgroupnumtxt.Text = "";
            GroupID = 0;



        }
    

        private void grp_num_btn_clear(object sender, EventArgs e)
        {
            //btn_clear 
            ClearData();
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
            string sqlstm = "Select Sid,GrpNumber from Student";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "Student");
            dataGridView3.DataSource = DS.Tables[0];


        }

        private void btn_g_num_editdetails(object sender, EventArgs e)
        {
            //btn edit details


            if (addgroupnumtxt.Text != "")
            {
                cmd = new SqlCommand("update Student set GrpNumber=@groupnumber  where Sid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Sid);
                cmd.Parameters.AddWithValue("@groupnumber", addgroupnumtxt.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Group Number Inserted Successfully");
                con.Close();
                ViewData();
                
                //CloseData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Insert Group number");
            }
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

            if (subgroupnum.Text != "")
            {
                cmd = new SqlCommand("insert into SubGroupNumber(SubGroupnumber) values(@subgroupnumber)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@subgroupnumber", subgroupnum.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                SeeData();
                FormatData();


            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }


        }
        //Display Data in DataGridView  
        private void SeeData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from SubGroupNumber ", con);
            adapt.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();


        }




        //Clear Data  
        private void FormatData()
        {
            subgroupnum.Text = "";
            SubGroupID = 0;



        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            //btn clear sub group
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            //  edit details sub group


            if (subgroupnum.Text != "")
            {
                cmd = new SqlCommand("update SubGroupNumber set SubGroupnumber=@subgroupnumber  where SubGroupID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", SubGroupID);
                cmd.Parameters.AddWithValue("@subgroupnumber", subgroupnum.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                SeeData();
                FormatData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }

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


            if (SubGroupID != 0)
            {
                cmd = new SqlCommand("delete SubGroupNumber where SubGroupID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", SubGroupID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                SeeData();
                FormatData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cell click yearsemester
            Sid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            yeartxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            semtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //cell click programme
            Sid = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            programtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cell click group numbers
            Sid = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            addgroupnumtxt.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cell click sub group
            SubGroupID = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString());
            subgroupnum.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        //refresh btn to  load programme data
        private void metroButton5_Click(object sender, EventArgs e)
        {
            string sqlstm = "Select Sid,Programme from Student";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "Student");
            dataGridView2.DataSource = DS.Tables[0];
        }
    }
}
