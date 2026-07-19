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
            Student student = new Student();

            books.Title = "Book of c#";
            books.Author = "Nahin";
            books.Price = 1200;

            BookManager bookManager = new BookManager();
            StudentManager studentManager = new StudentManager();

            //bookManager.Add(books);
            //studentManager.Add(student);




            int num;
            do
            {
                Console.WriteLine("1. Book");
                Console.WriteLine("2. Student");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your Choice = ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num == 1)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----Menu-----");
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. Delete");
                        Console.WriteLine("3. Update");
                        Console.WriteLine("4. ALL Book List");
                        Console.WriteLine("6. Back");
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
                    } while (num != 5);
                   
                }
                else if(num == 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----Menu-----");
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. Delete");
                        Console.WriteLine("3. Update");
                        Console.WriteLine("4. ALL Book List");
                        Console.WriteLine("6. Back");
                        Console.WriteLine();
                        Console.Write("Enter your Choice = ");
                        num = Convert.ToInt32(Console.ReadLine());

                        switch (num)
                        {
                            case 1:

                                //bookManager.Add(books);
                                studentManager.Add(student);

                                break;

                            case 2:

                                student.Id = Convert.ToInt32(Console.ReadLine());

                                studentManager.Delete(student.Id);
                                break;

                            case 3:


                                student.Id = Convert.ToInt32(Console.ReadLine());
                                studentManager.Update(student.Id);
                                break;

                            case 4:

                                studentManager.GetAll();
                                break;

                            case 5:


                                break;
                        }
                    } while (num != 6);
                }


               
            }
            while (num != 3);

        }
    }
}
