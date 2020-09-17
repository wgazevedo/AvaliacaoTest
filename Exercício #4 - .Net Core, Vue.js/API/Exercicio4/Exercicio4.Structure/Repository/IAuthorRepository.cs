using Exercicio4.Library.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio4.Data.Structure.Repository
{
    public interface IAuthorRepository
    {
        void Insert(Author author);
        void Update(Author author);
        void Delete(Author author);
        Author GetById(Guid id);
        IEnumerable<Author> GetAll();

    }
}
