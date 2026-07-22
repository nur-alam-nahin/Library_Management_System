using Library_Management_System.Entity;
using Library_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.LMS_BLL
{
    class BookManagerBll
    {
        Books books = new Books();
        BookManager bookManager = new BookManager();


        // book add
        public  void bookAdd()
        {
            Console.Write("Book Title: ");
            books.Title = Convert.ToString(Console.ReadLine());

            Console.Write("Book Author: ");
            books.Author = Convert.ToString(Console.ReadLine());

            Console.Write("Book Price: ");
            books.Price = Convert.ToDouble(Console.ReadLine());


            bookManager.Add(books);
        }




        // book delete

        public void bookDelete()
        {
            Console.Write("Enter Id: ");
            books.Id = Convert.ToInt32(Console.ReadLine());

            bookManager.Delete(books.Id);
        }




        // book update

        public void bookUpdate()
        {
            Console.Write("Enter Id: ");
            books.Id = Convert.ToInt32(Console.ReadLine());
            bookManager.Update(books.Id);
        }




        // book get all

        public void bookGetAll()
        {
            Console.WriteLine("------ Book List -----");
            bookManager.GetAll();
        }
    }
}
