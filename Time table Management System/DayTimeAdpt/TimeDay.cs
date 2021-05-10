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
    class TimeDay
    {
        //getter and setter

        public int timeday { get; set; }
        public string day1 { get; set; }
        public int time1 { get; set; }
        public string day2 { get; set; }
        public int time2 { get; set; }
        public string day3 { get; set; }
        public int time3 { get; set; }
        public string day4 { get; set; }
        public int time4 { get; set; }
        public string day5 { get; set; }
        public int time5 { get; set; }
        public string day6 { get; set; }
        public int time6 { get; set; }
        public string day7 { get; set; }
        public int time7 { get; set; }

        static string ourconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(ourconnstrng);
            DataTable dt1 = new DataTable();
            try
            {
                //Write Sql Query
                string sql = "SELECT * FROM day_time";
                //create command cmd using sql,conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create sql adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt1);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt1;
        }
        //Insert data into database
        public bool Insert(TimeDay t)
        {
            //create a default return type and setting its values to false
            bool isSuccess = false;

            //Connect Database
            SqlConnection conn = new SqlConnection(ourconnstrng);
            try
            {
                //Create query to insert data
                string sql = "INSERT INTO day_time(day1, time1,day2, time2,day3, time3,day4, time4,day5, time5,day6, time6,day7, time7) VALUES(@day1, @time1,@day2, @time2,@day3, @time3,@day4, @time4,@day5, @time5,@day6, @time6,@day7, @time7)";
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@day1", t.day1);
                cmd.Parameters.AddWithValue("@time1", t.time1);
                cmd.Parameters.AddWithValue("@day2", t.day2);
                cmd.Parameters.AddWithValue("@time2", t.time2);
                cmd.Parameters.AddWithValue("@day3", t.day3);
                cmd.Parameters.AddWithValue("@time3", t.time3);
                cmd.Parameters.AddWithValue("@day4", t.day4);
                cmd.Parameters.AddWithValue("@time4", t.time4);
                cmd.Parameters.AddWithValue("@day5", t.day5);
                cmd.Parameters.AddWithValue("@time5", t.time5);
                cmd.Parameters.AddWithValue("@day6", t.day6);
                cmd.Parameters.AddWithValue("@time6", t.time6);
                cmd.Parameters.AddWithValue("@day7", t.day7);
                cmd.Parameters.AddWithValue("@time7", t.time7);

                //Connection open here
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

        //Method to Update
        public bool Update(TimeDay t)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(ourconnstrng);

            try
            {
                //create sql update query
                string sql = "UPDATE day_time SET day1=@day1, time1=@time1, day2=@day2, time2=@time2, day3=@day3, time3=@time3, day4=@day4, time4=@time4, day5=@day5, time5=@time6, day6=@day6, time6=@time6, day7=@day7, time7=@time7 WHERE timeday=@timeday";

                //create slq command usind sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create parameter to add values
                cmd.Parameters.AddWithValue("@day1", t.day1);
                cmd.Parameters.AddWithValue("@time1", t.time1);
                cmd.Parameters.AddWithValue("@day2", t.day2);
                cmd.Parameters.AddWithValue("@time2", t.time2);
                cmd.Parameters.AddWithValue("@day3", t.day3);
                cmd.Parameters.AddWithValue("@time3", t.time3);
                cmd.Parameters.AddWithValue("@day4", t.day4);
                cmd.Parameters.AddWithValue("@time4", t.time4);
                cmd.Parameters.AddWithValue("@day5", t.day5);
                cmd.Parameters.AddWithValue("@time5", t.time5);
                cmd.Parameters.AddWithValue("@day6", t.day6);
                cmd.Parameters.AddWithValue("@time6", t.time6);
                cmd.Parameters.AddWithValue("@day7", t.day7);
                cmd.Parameters.AddWithValue("@time7", t.time7);
                cmd.Parameters.AddWithValue("@timeday", t.timeday);


                //Open database Connection
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
        //Method to delete data from databse

        public bool Delete(TimeDay t)
        {
            bool isSuccess = false;
            //create SQL Connection
            SqlConnection conn = new SqlConnection(ourconnstrng);
            try
            {
                //Sql delete data
                string sql = "DELETE FROM day_time WHERE timeday=@timeday ";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@timeday", t.timeday);

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
