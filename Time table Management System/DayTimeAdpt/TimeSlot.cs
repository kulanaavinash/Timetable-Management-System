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
    class TimeSlot
    {
        //getter setter Properties
        //acrs as data carrier in this application

        public int timeSlotNo { get; set; }
        public string datepicker { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }

        static string mconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data from database

        public DataTable Select()
        {
            //data connection
            SqlConnection conn = new SqlConnection(mconnstrng);
            DataTable dt2 = new DataTable();
            try
            {
                //Writing Sql query 
                string sql = "SELECT * FROM Time_slots";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create sql Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt2);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt2;
        }

        //Insert data into database
        public bool Insert(TimeSlot s)
        {
            //Create a default retrun type and setting its values to false
            bool isSuccess = false;

            //connct database
            SqlConnection conn = new SqlConnection(mconnstrng);
            try
            {
                //create a slq query to insert data
                string sql = "INSERT INTO Time_slots(datepicker, start_time, end_time) VALUES(@datepicker, @start_time, @end_time)";
                //Create Sql command using conn and sql
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@datepicker", s.datepicker);
                cmd.Parameters.AddWithValue("@start_time", s.start_time);
                cmd.Parameters.AddWithValue("@end_time", s.end_time);

                //Connection Open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the values of rows will be greater than 0 else its values will be 0
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

        //Mothen to update

        public bool Update(TimeSlot s)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(mconnstrng);
            try
            {
                //Create sql query
                string sql = "UPDATE Time_slots SET datepicker=@datepicker, start_time=@start_time, end_time=@end_time";

                //Create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create parameter to add values
                cmd.Parameters.AddWithValue("@datepicker", s.datepicker);
                cmd.Parameters.AddWithValue("@start_time", s.start_time);
                cmd.Parameters.AddWithValue("@end_time", s.end_time);

                //Connection Open
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

        //Method to dalete data from databse

        public bool Delete(TimeSlot s)
        {
            bool isSuccess = false;
            //SQL connrction
            SqlConnection conn = new SqlConnection(mconnstrng);

            try
            {
                //Sql delete query
                string sql = "DELETE FROM Time_slots Where timeSlotNo=@timeSlotNo";

                //Create sql Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@timeSlotNo", s.timeSlotNo);

                //open connection
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
