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

        public bool Insert(Insurance insurance)
        {
            bool result = false;

            try
            {
                SqlCommand cmd = new SqlCommand(Insurance.INSERT, conn);
                cmd.Parameters.Add(new SqlParameter("@Description", 
                    insurance.Description));
                cmd.ExecuteNonQuery();
                result = true;

            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
