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
    class NbDays
    {

        public int week { get; set; }
        public int days { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Select data from database

        public DataTable Select()
        {
            //Connection database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //Write sql query
                string sql = "SELECT * FROM NbDays";

                //Create command using sql,conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create sql adapter
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
        public bool Insert(NbDays n)
        {
            bool isSuccess = false;

            //Connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //create insert sql query
                string sql = "INSERT INTO NbDays(days) VALUES(@days)";
                //Create command using sql,conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@days", n.days);

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

        public bool Update(NbDays n)
        {
            bool isSucces = false;
            //Connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //create update sql query
                string sql = "UPDATE NbDays SET days=@days WHERE week=@week";

                //command 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameter
                cmd.Parameters.AddWithValue("@days", n.days);
                cmd.Parameters.AddWithValue("@week", n.week);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        public bool Delete(NbDays n)
        {
            bool isSuccess = false;
            //create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql delete data
                string sql = "DELETE FROM NbDays WHERE week=@week ";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@week", n.week);

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
