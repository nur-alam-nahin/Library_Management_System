using Library_Management_System.Entity;
using Library_Management_System.Repository.DataBaseHelper;
using Library_Management_System.Repository.IRepositroy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Repository
{
    class AdminManager : DBHelper ,  IAdminRepository
    {
        public void Add(Admin admin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = @"insert into tbl_admin(Name,Phone,Address) values(@Name,@Phone,@Address)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Name", admin.Name);
                cmd.Parameters.AddWithValue("Phone", admin.Phone);
                cmd.Parameters.AddWithValue("Address", admin.Address);

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine("Admin Add successfully");
                }
                else
                {
                    Console.WriteLine("Admin Add Failed");
                }
                connection.Close();


            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"DELETE  FROM tbl_admin WHERE EmployeeId = @EmployeeId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("EmployeeId", Id);

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine("Admin Delete successfully");
                }
                connection.Close();
            }
        }

        public List<Admin> GetAll()
        {
            List<Admin> dataList = new List<Admin>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tbl_admin";
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Admin admin = new Admin();

                    admin.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                    admin.Name = Convert.ToString(reader["Name"]);
                    admin.Phone = Convert.ToString(reader["Phone"]);
                    admin.Address = Convert.ToString(reader["Address"]);

                    dataList.Add(admin);

                    Console.WriteLine($"{admin.EmployeeId} {admin.Name} {admin.Phone} {admin.Address}");
                }
            }

            return dataList;
        }

        public void Update(int Id)
        {
            Admin admin = new Admin();

            Console.Write("Student Name: ");
            admin.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Student Phone: ");
            admin.Phone = Convert.ToString(Console.ReadLine());

            Console.Write("Student Address: ");
            admin.Address = Convert.ToString(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE tbl_admin set Name = @Name , Phone = @Phone , Address = @Address where EmployeeId = @EmployeeId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("EmployeeId", Id);
                cmd.Parameters.AddWithValue("Name", admin.Name);
                cmd.Parameters.AddWithValue("Phone", admin.Phone);
                cmd.Parameters.AddWithValue("Address", admin.Address);

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine("Admin Info Update Successfully");
                }

                connection.Close();
            }
        }
    }
}
