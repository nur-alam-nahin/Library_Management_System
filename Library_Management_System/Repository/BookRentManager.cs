using Library_Management_System.Entity;
using Library_Management_System.Repository.IRepositroy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Repository
{
    class BookRentManager : IBookRentRepository
    {

        private string connectionString = "Server=.;Database=lms_DB;Integrated Security = True;";

        public void Add()
        {
            
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<BookRent> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
