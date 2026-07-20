using Library_Management_System.Entity;
using Library_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.LMS_BLL
{
    class BookRentBll
    {
        Student student = new Student();
        Books books = new Books();
        BookRent bookRent = new BookRent();
        BookRentManager rentManager = new BookRentManager();

        BookManager bookManager = new BookManager();
        StudentManager studentManager = new StudentManager();

        //Registration
        public void rent()
        {
            Console.WriteLine("------ Student form -----");
            Console.Write("Student Name: ");
            student.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Student Phone: ");
            student.Phone = Convert.ToString(Console.ReadLine());

            Console.Write("Student Address: ");
            student.Address = Convert.ToString(Console.ReadLine());

            studentManager.Add(student);

            Console.WriteLine();
            Console.WriteLine("------ Student List -----");
            studentManager.GetAll();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Student Id: ");
            bookRent.studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("------ Book List -----");
            bookManager.GetAll();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Book Id: ");
            bookRent.bookId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Duration: ");
            bookRent.duration = Convert.ToInt32(Console.ReadLine());

            Console.Write("Rental Cost: ");
            bookRent.RentCost = Convert.ToDouble(Console.ReadLine());

            rentManager.Add(bookRent);

        }

    }
}
