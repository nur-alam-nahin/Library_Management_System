using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Entity;

namespace Library_Management_System.Repository
{
    class BookManager : IBookRepository
    {
        private string connectionString = "Server=.;Database=lms_DB;Integrated Security = True;";

        public void Add(Books books)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"insert into tbl_book(Title,Author,Price) values(@Title,@Author,@Price)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Title", books.Title);
                cmd.Parameters.AddWithValue("Author", books.Author);
                cmd.Parameters.AddWithValue("Price", books.Price);

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if(n > 0)
                {
                    Console.WriteLine("Book Add successfully");
                }
                else
                {
                    Console.WriteLine("Book Add Failed");
                }
                connection.Close();


            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"DELETE  FROM tbl_book WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Id", Id);

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if(n > 0)
                {
                    Console.WriteLine("Book Delete successfully");
                }
                connection.Close();
            }
        }

        public List<Books> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
