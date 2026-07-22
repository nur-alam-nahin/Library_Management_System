using Library_Management_System.Entity;
using Library_Management_System.Repository.IRepositroy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Repository
{
    class BookRentManager : IBookRentRepository
    {

        private string connectionString = "Server=.;Database=lms_DB;Integrated Security = True;";

        public void Add(BookRent bookRent)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = @"insert into tbl_bookRent(StudentId,BookId,Duration,BookRent) values(@StudentId,@BookId,@Duration,@BookRent)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("StudentId", bookRent.studentId);
                cmd.Parameters.AddWithValue("BookId", bookRent.bookId);
                cmd.Parameters.AddWithValue("Duration", bookRent.duration);
                cmd.Parameters.AddWithValue("BookRent", bookRent.RentCost);

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine("Info Add successfully");
                }
                else
                {
                    Console.WriteLine("Info Add Failed");
                }
                connection.Close();


            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"DELETE FROM tbl_bookRent where Id = @Id";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("Id", Id);

                connection.Open();

                int n = cmd.ExecuteNonQuery();

                if(n > 0)
                {
                    Console.WriteLine("Info Delete successfully");
                }
                connection.Close();
            }
        }

        public List<BookRent> GetAll()
        {
            List<BookRent> dataList = new List<BookRent>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from tbl_bookRent";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {

                }
            }

            return dataList;
        }

        public void Update(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
