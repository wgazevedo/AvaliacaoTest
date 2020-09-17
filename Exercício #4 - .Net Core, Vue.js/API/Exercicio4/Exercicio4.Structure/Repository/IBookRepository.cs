using Exercicio4.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Data.Structure.Repository
{
    public interface IBookRepository
    {
        void Insert(Book book);
        void Update(Book book);
        void Delete(Book book);
        Book GetById(Guid id);
        IEnumerable<Book> GetAll();
    }
}
