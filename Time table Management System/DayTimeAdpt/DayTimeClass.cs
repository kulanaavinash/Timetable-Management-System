using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_table_Management_System.DayTimeAdpt
{
    class DayTimeClass
    {
        //Getting Setter Properties
        //Acts as data carrier in this application

        public int sessionID { get; set; }
        public string faculty { get; set; }
        public string lecture { get; set; }
        public int session_type { get; set; }
        public string date { get; set; }
        public string class_room { get; set; }
        public string department { get; set; }
        public string session { get; set; }
        public string center { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //selecting data from databse

        public DataTable Select()
        {
            //data connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL query
                string sql = "SELECT * FROM add_session";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting data into Database
        public bool Insert(DayTimeClass c)
        {
            //creating a defult return type and setting  its values to false
            bool isSuccess = false;

            //connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //create a query to insert data
                string sql = "INSERT INTO add_session(faculty, lecture, session_type, date, class_room, department, session, center) VALUES (@faculty, @lecture, @session_type, @date, @class_room, @department, @session, @center)";
                //creating sql command using sql and conn 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameter to add data 
                cmd.Parameters.AddWithValue("@faculty", c.faculty);
                cmd.Parameters.AddWithValue("@lecture", c.lecture);
                cmd.Parameters.AddWithValue("@session_type", c.session_type);
                cmd.Parameters.AddWithValue("@date", c.date);
                cmd.Parameters.AddWithValue("@class_room", c.class_room);
                cmd.Parameters.AddWithValue("@department", c.department);
                cmd.Parameters.AddWithValue("@session", c.session);
                cmd.Parameters.AddWithValue("@center", c.center);

                //Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the vatues of rows will be greater than zero else its values will ne 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return isSuccess;
        }

        //Method to update

        public bool Update(DayTimeClass c)
        {
            //Create a defult return type and set its default value to fslse
            bool isSuccsess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql to update data in databse
                string sql = "UPDATE add_session SET faculty=@faculty, lecture=@lecture, session_type=@session_type, date=@date, class_room=@class_room, department=@department, session=@session, center=@center";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameter to add values
                cmd.Parameters.AddWithValue("@faculty", c.faculty);
                cmd.Parameters.AddWithValue("@lecture", c.lecture);
                cmd.Parameters.AddWithValue("@session_type", c.session_type);
                cmd.Parameters.AddWithValue("@date", c.date);
                cmd.Parameters.AddWithValue("@class_room", c.class_room);
                cmd.Parameters.AddWithValue("@department", c.department);
                cmd.Parameters.AddWithValue("@session", c.session);
                cmd.Parameters.AddWithValue("@center", c.center);

                //Open database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccsess = true;
                }
                else
                {
                    isSuccsess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccsess;
        }

        //Method to delete data from databse

        public bool Delete(DayTimeClass c)
        {
            bool isSuccess = false;
            //create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql delete data
                string sql = "DELETE FROM add_session WHERE sessionID=@sessionID ";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sessionID", c.sessionID);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
