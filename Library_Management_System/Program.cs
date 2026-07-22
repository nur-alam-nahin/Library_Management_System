using Library_Management_System.Entity;
using Library_Management_System.LMS_BLL;
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
            
             
         

            BookManager bookManager = new BookManager();
            StudentManager studentManager = new StudentManager();

            //bookManager.Add(books);
            //studentManager.Add(student);




            int num;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Book");
                Console.WriteLine("2. Student");
                Console.WriteLine("3. Book Rent");
                Console.WriteLine("4. Exit");
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
                                Console.Write("Book Title: ");
                                books.Title = Convert.ToString(Console.ReadLine());

                                Console.Write("Book Author: ");
                                books.Author = Convert.ToString(Console.ReadLine());

                                Console.Write("Book Price: ");
                                books.Price = Convert.ToDouble(Console.ReadLine());


                                bookManager.Add(books);
                               

                                break;

                            case 2:

                                Console.Write("Enter Id: ");
                                books.Id = Convert.ToInt32(Console.ReadLine());

                                bookManager.Delete(books.Id);
                                break;

                            case 3:

                                Console.Write("Enter Id: ");
                                books.Id = Convert.ToInt32(Console.ReadLine());
                                bookManager.Update(books.Id);
                                break;

                            case 4:

                                bookManager.GetAll();
                                break;

                            case 5:


                                break;
                        }
                    } while (num != 6);
                   
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
                        Console.WriteLine("4. ALL Student List");
                        Console.WriteLine("6. Back");
                        Console.WriteLine();
                        Console.Write("Enter your Choice = ");
                        num = Convert.ToInt32(Console.ReadLine());

                        switch (num)
                        {
                            case 1:

                                Console.Write("Student Name: ");
                                student.Name = Convert.ToString(Console.ReadLine());

                                Console.Write("Student Phone: ");
                                student.Phone = Convert.ToString(Console.ReadLine());

                                Console.Write("Student Address: ");
                                student.Address = Convert.ToString(Console.ReadLine());
                                
                                studentManager.Add(student);

                                break;

                            case 2:
                                Console.Write("Enter Id: ");
                                student.Id = Convert.ToInt32(Console.ReadLine());

                                studentManager.Delete(student.Id);
                                break;

                            case 3:

                                Console.Write("Enter Id: ");
                                student.Id = Convert.ToInt32(Console.ReadLine());
                                studentManager.Update(student.Id);
                                break;

                            case 4:
                                Console.WriteLine("------ Student List -----");
                                studentManager.GetAll();
                                break;

                            case 5:


                                break;
                        }
                    } while (num != 6);
                }
                else if(num == 3)
                {
                    BookRentBll bookRentBll = new BookRentBll();

                    bookRentBll.rent();
                }


               
            }
            while (num != 4);

        }
    }
}
