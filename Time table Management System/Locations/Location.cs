using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;



namespace Time_table_Management_System
{

    public partial class Location : Form

    {

        SqlConnection con = new SqlConnection("Server=tcp:acdemicmysql.database.windows.net,1433;Initial Catalog=Timetable;Persist Security Info=False;User ID=adminonline;Password=V41823*9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        string cs = "Server=tcp:acdemicmysql.database.windows.net,1433;Initial Catalog=Timetable;Persist Security Info=False;User ID=adminonline;Password=V41823*9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



       // SqlConnection con = new SqlConnection("Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True");
     //   string cs = "Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True";

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

        private void LoadLocations()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from locations", con);
            DataTable dt = new DataTable();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);


            loc_dgridv.AutoGenerateColumns = true;
            loc_dgridv.DataSource = dt;
            con.Close();
        }


        public Location()
        {
            InitializeComponent();
            LoadLocations();

            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }





        //new
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
          /* view_Location1.Hide();
            add_location1.Hide();
            edit_Delete_Location1.Hide(); */
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
             /*view_Location1.Hide();
            edit_Delete_Location1.Hide();

            add_location1.Show();
           add_location1.BringToFront();*/
        }

        private void button17_Click(object sender, EventArgs e)
        {
           /*add_location1.Hide();
           view_Location1.Hide();

           edit_Delete_Location1.Show();
           edit_Delete_Location1.BringToFront();*/
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void loc_dgridv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void loc_tabcontrol_Click(object sender, EventArgs e)
        {
           /* add_location1.Hide();
            edit_Delete_Location1.Hide();

            view_Location1.Show();
            view_Location1.BringToFront(); */
        }

        private void edit_Delete_Location1_Load(object sender, EventArgs e)
        {

        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Location_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void search_by_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            


        }
        private void loc_dgridv_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            loc_dgridv.Sort(loc_dgridv.Columns[0], ListSortDirection.Ascending);
            loc_dgridv.Sort(loc_dgridv.Columns[1], ListSortDirection.Ascending);
            loc_dgridv.Sort(loc_dgridv.Columns[2], ListSortDirection.Descending);
            loc_dgridv.Sort(loc_dgridv.Columns[3], ListSortDirection.Ascending);
        }

        private void loc_dgridv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_txt_box_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void building_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void room_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void capacity_cmb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void roomtype_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addloc_btn_Click(object sender, EventArgs e)
        {
            if ((building_cmb.Text != string.Empty) && (room_cmb.Text != string.Empty) && (capacity_cmb.Text != string.Empty)
               && (roomtype_cmb.Text != string.Empty))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [dbo].[Locations] ([building],[room],[capacity],[room_type]) VALUES ('" + building_cmb.Text + "','" + room_cmb.Text + "'," + capacity_cmb.Value + ",'" + roomtype_cmb.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Location Added!");
                con.Close();

               LoadLocations();
               ClearLocationData();
               ClearUpdateLocDetails();
               loc_tabcontrol.SelectedTab = viewloc_tab;

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       


        //fill combo box with database data


        private void building_cmb_DropDown(object sender, EventArgs e)
        {
            building_cmb.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Building_Name FROM buildings";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {
                building_cmb.Items.Add(dr["Building_Name"].ToString());
            }

            con.Close();
        }

        private void room_cmb_DropDown(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT room_num from rooms where building_name ='" + building_cmb.Text + "'", con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            room_cmb.Items.Clear();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                room_cmb.Items.Add(dataRow["room_num"].ToString());
            }
        }

        private void ClearLocationData()
        {
            building_cmb.SelectedIndex = -1;
            room_cmb.SelectedIndex = -1;
            capacity_cmb.Value = 0;
            roomtype_cmb.SelectedIndex = -1;

        }

        private void clr_btn_Click(object sender, EventArgs e)
        {

            ClearLocationData();

        }

        private void ClearUpdateLocDetails()
        {
            editroom_cmb.SelectedIndex = -1;
            edit_building_txt_box.Clear();
            editcap_cmb.Value = 0;
            room_type_txt_box.SelectedIndex = -1;
        }


        private void metroLabel8_Click(object sender, EventArgs e)
        {
           
        }

        private void editroom_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM locations WHERE room = '" + editroom_cmb.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string r_building = (string)dr["building"].ToString();
                edit_building_txt_box.Text = r_building;
                

                string r_capacity = (string)dr["capacity"].ToString();
                editcap_cmb.Text = r_capacity;

                string r_type = (string)dr["room_type"].ToString();
                room_type_txt_box.Text = r_type;
                
            }
            con.Close();
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void edit_building_txt_box_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void editcap_cmb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void room_type_txt_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editloc_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE locations SET capacity ='" + editcap_cmb.Text + "',room_type = '" + room_type_txt_box.Text + "' WHERE room ='" + editroom_cmb.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Location Updated!");
            con.Close();

            LoadLocations();
            ClearUpdateLocDetails();
            loc_tabcontrol.SelectedTab = viewloc_tab;
        }

        private void Location_Load(object sender, EventArgs e)
        {
            LoadLocations();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM locations WHERE room = '" + editroom_cmb.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Location Deleted!");
            con.Close();

            LoadLocations();
            loc_tabcontrol.SelectedTab = viewloc_tab;
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void locationview_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void editroom_cmb_DropDown(object sender, EventArgs e)
        {

            editroom_cmb.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT room FROM locations";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {
                editroom_cmb.Items.Add(dr["room"].ToString());
            }

            con.Close();

        }

        private void search_txt_box_TextChanged(object sender, EventArgs e)
        {
            //text change loaction search

            if(search_by_cmb.Text == "Room")
            {
                // SqlConnection con = Config.con;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT room,building,capacity,room_type FROM Locations WHERE room LIKE '%" + search_txt_box.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                loc_dgridv.DataSource = dt;
                con.Close();
            }
            else if (search_by_cmb.Text == "Building")
            {
                // SqlConnection con = Config.con;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT room,building,capacity,room_type FROM Locations WHERE building LIKE '%" + search_txt_box.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                loc_dgridv.DataSource = dt;
                con.Close();
            }
            else if (search_by_cmb.Text == "Capacity")
            {
                // SqlConnection con = Config.con;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT room,building,capacity,room_type FROM Locations WHERE capacity LIKE '%" + search_txt_box.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                loc_dgridv.DataSource = dt;
                con.Close();
            }
            else if (search_by_cmb.Text == "Room Type")
            {
                // SqlConnection con = Config.con;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT room,building,capacity,room_type FROM Locations WHERE room_type LIKE '%" + search_txt_box.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                loc_dgridv.DataSource = dt;
                con.Close();
            }

        }

        private void editloc_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
