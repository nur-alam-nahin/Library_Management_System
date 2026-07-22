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


            BookManagerBll bookManagerBll = new BookManagerBll();
            StudentManagerBll studentManagerBll = new StudentManagerBll();

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

                                bookManagerBll.bookAdd();

                                break;

                            case 2:

                                bookManagerBll.bookDelete();

                                break;

                            case 3:

                                bookManagerBll.bookUpdate();

                                break;

                            case 4:

                                bookManagerBll.bookGetAll();

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

                                studentManagerBll.studentAdd();

                                break;

                            case 2:

                                studentManagerBll.studentDelete();

                                break;

                            case 3:

                                studentManagerBll.studentUpdate();

                                break;

                            case 4:

                                studentManagerBll.studentGetAll();

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
