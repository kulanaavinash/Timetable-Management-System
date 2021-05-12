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
    class NotAvailableTime
    {
        //getter & setter properties
        //acrs as data carrier in this application

        public int NATno { get; set; }
        public string stype { get; set; }
        public string sitems { get; set; }
        public string stime { get; set; }
        public string etime { get; set; }
        public string date { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //setect data from database

        public DataTable Select()
        {
            //data connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt5 = new DataTable();
            try
            {
                //write sql query
                string sql = "SELECT * FROM NAT";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt5);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt5;
        }
        //Insert data into database
        public bool Insert(NotAvailableTime a)
        {
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql query
                string sql = "INSERT INTO NAT(stype, sitems, stime, etime, date) VALUES(@stype, @sitems, @stime, @etime, @date)";
                //Slq command using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameter to add data
                cmd.Parameters.AddWithValue("@stype", a.stype);
                cmd.Parameters.AddWithValue("@sitems", a.sitems);
                cmd.Parameters.AddWithValue("@stime", a.stime);
                cmd.Parameters.AddWithValue("@etime", a.etime);
                cmd.Parameters.AddWithValue("@date", a.date);

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

            }
            return isSuccess;
        }

        //method delete

        public bool Delete(NotAvailableTime a)
        {
            bool isSuccess = false;
            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Sql query
                string sql = "DELETE FROM NAT WHERE NATno=@NATno";

                //Create sql Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NATno", a.NATno);

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
