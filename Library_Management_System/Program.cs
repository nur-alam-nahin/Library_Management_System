using Library_Management_System.Entity;
using Library_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {

            Books books = new Books();

            books.Title = "Book of c#";
            books.Author = "Nahin";
            books.Price = 1200;

            BookManager bookManager = new BookManager();

            bookManager.Add(books);




            int num;
            do
            {
                Console.WriteLine();
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. ALL Book List");
                Console.WriteLine("5. Delete Account");
                Console.WriteLine("6. Logout");
                Console.WriteLine();
                Console.Write("Enter your Choice = ");
                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:

                        bookManager.Add(books);

                        break;

                    case 2:

                        books.Id = Convert.ToInt32(Console.ReadLine());

                        bookManager.Delete(books.Id);
                        break;

                    case 3:


                        books.Id = Convert.ToInt32(Console.ReadLine());
                        bookManager.Update(books.Id);
                        break;

                    case 4:

                        bookManager.GetAll();
                        break;

                    case 5:

                
                        break;
                }
            }
            while (num != 6);

        }
    }
}
