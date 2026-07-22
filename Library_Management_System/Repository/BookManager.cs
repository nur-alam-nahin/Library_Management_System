using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Entity;
using Library_Management_System.Repository.DataBaseHelper;

namespace Library_Management_System.Repository
{
    class BookManager : DBHelper , IBookRepository
    {
       

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

            List<Books> dataList = new List<Books>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_book";

            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Books books = new Books();

                books.Id = Convert.ToInt32(reader["Id"]);
                books.Title = Convert.ToString(reader["Title"]);
                books.Author = Convert.ToString(reader["Author"]);
                books.Price = Convert.ToDouble(reader["Price"]);

                dataList.Add(books);
                Console.WriteLine($"{books.Id} {books.Title} {books.Author} {books.Price}");
            }

            return dataList;
            
        }

        public void Update(int Id)
        {
            Books books = new Books();

            Console.Write("Title : ");
            books.Title = Convert.ToString(Console.ReadLine());

            Console.Write("Author : ");
            books.Author = Convert.ToString(Console.ReadLine());

            Console.Write("price : ");
            books.Price = Convert.ToDouble(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE tbl_book set Title = @Title , Author = @Author ,Price = @Price where Id = @Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Id", Id);
                cmd.Parameters.AddWithValue("Title", books.Title);
                cmd.Parameters.AddWithValue("Author", books.Author);
                cmd.Parameters.AddWithValue("Price", books.Price);


                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine("Book update successfully");
                }
                connection.Close();
            }
        }
    }
}
