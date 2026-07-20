using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Entity;

namespace Library_Management_System.Repository
{
    public class StudentManager : IStudentRepository
    {
        private string connectionString = "Server=.;Database=lms_DB;Integrated Security = True;";

        public void Add(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = @"insert into tbl_student(Name,Phone,Address) values(@Name,@Phone,@Address)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Name", student.Name);
                cmd.Parameters.AddWithValue("Phone", student.Phone);
                cmd.Parameters.AddWithValue("Address", student.Address); 

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine("Student Add successfully");
                }
                else
                {
                    Console.WriteLine("Studnet Add Failed");
                }
                connection.Close();


            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"DELETE  FROM tbl_student WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Id", Id);

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine("Student Delete successfully");
                }
                connection.Close();
            }
        }

        public List<Student> GetAll()
        {
            List<Student> dataList = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tbl_student";
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Student student = new Student();

                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Name = Convert.ToString( reader["Name"]);
                    student.Phone = Convert.ToString(reader["Phone"]);
                    student.Address = Convert.ToString(reader["Address"]);

                    dataList.Add(student);

                    Console.WriteLine($"{student.Id} {student.Name} {student.Phone} {student.Address}");
                }
            }

            return dataList;
        }

        public void Update(int Id)
        {


          
            Student student = new Student();

            Console.Write("Student Name: ");
            student.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Student Phone: ");
            student.Phone = Convert.ToString(Console.ReadLine());

            Console.Write("Student Address: ");
            student.Address = Convert.ToString(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE tbl_student set Name = @Name , Phone = @Phone , Address = @Address where Id = @Id";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Id", Id);
                cmd.Parameters.AddWithValue("Name", student.Name);
                cmd.Parameters.AddWithValue("Phone", student.Phone);
                cmd.Parameters.AddWithValue("Address", student.Address);

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if(n > 0)
                {
                    Console.WriteLine("Student Info Update Successfully");
                }

                connection.Close();
            }
        }
    }
}
