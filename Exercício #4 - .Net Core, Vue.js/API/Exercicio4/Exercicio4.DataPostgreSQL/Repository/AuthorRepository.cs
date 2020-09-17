using Exercicio4.Data.Structure.Repository;
using Exercicio4.DataPostgreSQL.Context;
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
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ISession session) : base(session)
        { }

        public Task<List<Author>> GetAllAsync()
        {
            var authors = Query.ToListAsync();

            return authors;
        }

        public async Task<Author> GetByIdAsync(Guid id)
        {
            var author = await Query
                                .Where(b => b.Id == id)
                                .FirstOrDefaultAsync();
            return author;
        }

        public async Task InsertAsync(Author author)
        {
            await Save(author);
        }

        public async Task UpdateAsync(Author author)
        {
            await Save(author);
        }

        public async Task RemoveAsync(Author author)
        {
            await Delete(author);
        }
    }
}
