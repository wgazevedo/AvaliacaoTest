using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Data.Structure.Repository
{
    public interface IAuthorRepository
    {
        void Insert(Author author);
        void Update(Author author);
        void Delete(Author author);
        Author GetById(int id);
        IEnumerable<Author> GetAll();

    }
}
