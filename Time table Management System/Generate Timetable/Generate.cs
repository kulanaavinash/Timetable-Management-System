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
using System.Collections;

namespace Time_table_Management_System
{

    public partial class Generate : Form
    {


        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True");
        string cs = "Data Source=LAPTOP-DISMT73N;Initial Catalog=TimetableManagmentDB;Integrated Security=True";



        public int hr = 8;
        public int min = 30;
        public int sec = 0;

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



        private void timeCalc(int hr1, int min1, int sec1)
        {

            sec += sec1;

            if (sec > 60)
            {
                min++;
                sec -= 60;
            }

            min += min1;

            if (min > 60)
            {
                hr++;
                min -= 60;
            }

            hr += hr1;
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


            

            String query1 = "select lectures,tag,Sgroup,subject,time,day from sessionsDB order by time";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            DataTable newData = new DataTable();

            newData.Columns.Add("Time", typeof(String));
            newData.Columns.Add("Monday", typeof(String));
            newData.Columns.Add("Tuesday", typeof(String));
            newData.Columns.Add("Wednesday", typeof(String));
            newData.Columns.Add("Thursday", typeof(String));
            newData.Columns.Add("Friday", typeof(String));
            newData.Columns.Add("Saturday", typeof(String));
            newData.Columns.Add("Sunday", typeof(String));

            String[] timeSlot = new String[] { "08.30-09.30", "09.30-10.30", "10.30-11.30", "11.30-12.30", "12.30-1.30", "01.30-02.30", "02.30-03.30", "03.30-04.30", "04.30-05.30" };

            for (int i = 0; i < timeSlot.Length; i++)
            {
                newData.Rows.Add(new object[] { timeSlot[i], "--", "--", "--", "--", "--", "--", "--" });
            }

            foreach (DataRow row in dt.Rows)
            {
                string ss = row[0] + ":" + row[1] + ":" + row[2] + ":" + row[3] + ":" + row[4] + ":" + row[5];
                string col = null;

                if (row[5].Equals("Monday"))
                {
                    col = "Monday";
                }
                else if (row[5].Equals("Tuesday"))
                {
                    col = "Tuesday";
                }
                else if (row[5].Equals("Wednesday"))
                {
                    col = "Wednesday";
                }
                else if (row[5].Equals("Thursday"))
                {
                    col = "Thursday";
                }
                else if (row[5].Equals("Friday"))
                {
                    col = "Friday";
                }

                for (int i = 0; i < timeSlot.Length; i++)
                {
                    if (row[4].Equals(timeSlot[i]))
                    {
                        newData.Rows[i][col] = ss;
                        break;
                    }
                }
            }

            metroGrid1.DataSource = newData;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // view lec ---print timetable btn----//

            printDocument1.Print();


           
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

            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select Sgroup,Subject,durations,tag from sessionsDB where Seid LIKE '%" + comboBox1.Text + "%'";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dataGridView2.ColumnCount = 8;
            dataGridView2.Columns[0].Name = "";
            dataGridView2.Columns[1].Name = "Monday";
            dataGridView2.Columns[2].Name = "Tuesday";
            dataGridView2.Columns[3].Name = "Wednesday";
            dataGridView2.Columns[4].Name = "Thursday";
            dataGridView2.Columns[5].Name = "Friday";
            dataGridView2.Columns[6].Name = "Saturday";
            dataGridView2.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    try
                    {
                        dataGridView2.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView2.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {
                }

                dataGridView2.Rows.Add(row);
            }

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
            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select roomid,sub_tag from room_subtag where roomid LIKE '%" + comboBox1.Text + "%'";



            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dataGridView3.ColumnCount = 8;
            dataGridView3.Columns[0].Name = "";
            dataGridView3.Columns[1].Name = "Monday";
            dataGridView3.Columns[2].Name = "Tuesday";
            dataGridView3.Columns[3].Name = "Wednesday";
            dataGridView3.Columns[4].Name = "Thursday";
            dataGridView3.Columns[5].Name = "Friday";
            dataGridView3.Columns[6].Name = "Saturday";
            dataGridView3.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    try
                    {
                        dataGridView3.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView3.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {
                }

                dataGridView3.Rows.Add(row);
            }



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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.metroGrid1.Width, this.metroGrid1.Height);
            metroGrid1.DrawToBitmap(bm, new Rectangle(0, 0, this.metroGrid1.Width, this.metroGrid1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
