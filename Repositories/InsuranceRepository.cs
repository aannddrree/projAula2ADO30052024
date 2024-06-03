using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class InsuranceRepository
    {

        string strConn = "Server=DESKTOP-6NSSVDC;Database=projAula2;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=Yes";
        SqlConnection conn;

        public InsuranceRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public int Insert(Insurance insurance)
        {
            int result = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(Insurance.INSERT, conn);
                cmd.Parameters.Add(new SqlParameter("@Description", insurance.Description));
                result = (int) cmd.ExecuteScalar();

            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR: " + e.Message);
                //throw;
                result = 0;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
