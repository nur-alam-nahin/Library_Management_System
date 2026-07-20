using Library_Management_System.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Repository
{
    public interface IStudentRepository
    {
        void Add(Student student);
        void Update(int Id);
        void Delete(int Id);
        List<Student> GetAll();
    }
}
