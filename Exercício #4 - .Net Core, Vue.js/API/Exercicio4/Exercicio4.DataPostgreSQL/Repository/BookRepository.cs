using Exercicio4.Data.Structure.Repository;
using Exercicio4.Library.Entities;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.DataPostgreSQL.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(ISession session) : base(session)
        {
        }

        public Task<List<Book>> GetAllAsync()
        {
            var books = Query.ToListAsync();

            return books;
        }

        public async Task<Book> GetByIdAsync(Guid id)
        {
            var book = await Query
                                .Where(b => b.Id == id)
                                .FirstOrDefaultAsync();
            return book;
        }

        public async Task InsertAsync(Book book)
        {
            await Save(book);
        }

        public async Task UpdateAsync(Book book)
        {
            await Save(book);
        }

        public async Task RemoveAsync(Book book)
        {
            await Delete(book);
        }
    }
}
