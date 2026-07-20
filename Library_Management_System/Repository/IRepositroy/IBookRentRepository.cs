using Library_Management_System.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Repository.IRepositroy
{
    public interface IBookRentRepository
    {
        void Add(BookRent bookRent);

        void Update(int Id);

        void Delete(int Id);

        List<BookRent> GetAll();
    }
}
