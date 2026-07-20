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
            throw new NotImplementedException();
        }

        public List<BookRent> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
