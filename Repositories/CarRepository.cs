using Microsoft.Data.SqlClient;
using Models;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repositories
{
    public class CarRepository
    {
        string strConn = "Server=DESKTOP-6NSSVDC;Database=projAula2;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=Yes";
        SqlConnection conn;

        public CarRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Car car)
        {
            bool result = false;

            try
            {
                SqlCommand cmd = new SqlCommand(Car.INSERT, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", car.Name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
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

        public bool Update(Car car)
        {
            bool result = false;

            try
            {
                SqlCommand cmd = new SqlCommand(Car.UPDATE, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", car.Name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
                cmd.Parameters.Add(new SqlParameter("@Id", car.Id));
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

        public bool Delete(int id)
        {
            bool result = false;

            try
            {
                SqlCommand cmd = new SqlCommand(Car.DELETE, conn);
                cmd.Parameters.Add(new SqlParameter("@Id", id));

                return (cmd.ExecuteNonQuery() > 0);

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

        public List<Car> GetAll()
        {
            List<Car> cars = new List<Car>();

            StringBuilder sb = new StringBuilder();
            sb.Append(Car.GETALL);

            /* sb.Append("SELECT Id, ");
             sb.Append("       Name, ");
             sb.Append("       Color, ");
             sb.Append("       Year ");
             sb.Append("  FROM TB_CAR");*/

            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car();
                    car.Id = reader.GetInt32(0);
                    car.Name = reader.GetString(1);
                    car.Color = reader.GetString(2);
                    car.Year = reader.GetInt32(3);
                    cars.Add(car);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return cars;
        }

        public Car? Get(int id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Car.GET);
            Car? car = null;
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.Add(new SqlParameter("@Id", id));

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    car = new Car();
                    car.Id = reader.GetInt32(0);
                    car.Name = reader.GetString(1);
                    car.Color = reader.GetString(2);
                    car.Year = reader.GetInt32(3);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return car;
        }
    }
}
