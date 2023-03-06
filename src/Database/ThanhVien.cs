using System;
using System.Data.SqlClient;
namespace KTLT2_TAODOITUONG
{
    class ThanhVien
    {
        public static void Connection()
        {
            Console.WriteLine("Getting Connection ...");

            var datasource = @"DESKTOP-FJE0RF8";//your server
            var database = "SinhVien"; //your database name
            //var username = "DESKTOP-FJE0RF8\\thanh"; //username of server to connect
            //var password = "123"; //password

            //your connection string 
            //string connString = @"Data Source=" + datasource + ";Initial Catalog="
            //            + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Trusted_Connection=True;";

            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();
                // reading 1 dong trong table tra ve ket qua 1 doi tuong va luu vao 1 danh sach


                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }
}
