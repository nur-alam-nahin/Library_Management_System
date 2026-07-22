using Library_Management_System.Entity;
using Library_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.LMS_BLL
{
    class StudentManagerBll
    {
        Student student = new Student();
        StudentManager studentManager = new StudentManager();


        // student add
        public void studentAdd()
        {
            Console.Write("Student Name: ");
            student.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Student Phone: ");
            student.Phone = Convert.ToString(Console.ReadLine());

            Console.Write("Student Address: ");
            student.Address = Convert.ToString(Console.ReadLine());

            studentManager.Add(student);
        }



        // student delete
        public void studentDelete()
        {
            Console.Write("Enter Id: ");
            student.Id = Convert.ToInt32(Console.ReadLine());

            studentManager.Delete(student.Id);
        }



        // student update
        public void studentUpdate()
        {
            Console.Write("Enter Id: ");
            student.Id = Convert.ToInt32(Console.ReadLine());
            studentManager.Update(student.Id);
        }



        // student get all
        public void studentGetAll()
        {
            Console.WriteLine("------ Student List -----");
            studentManager.GetAll();
        }
    }
}
