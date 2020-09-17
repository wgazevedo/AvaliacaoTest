using Exercicio4.Data.Structure.Repository;
using Exercicio4.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.Business.Components
{
    public class BookComponent
    {
        private readonly IBookRepository repository;

        public BookComponent(IBookRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Book> GetByIdAsync(Guid id)
        {
            return await repository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task Insert(Book book)
        {
            await repository.InsertAsync(book);
        }

        public async Task Update(Guid id, Book book)
        {
            if (id != null && id != Guid.Empty)
                if (await repository.GetByIdAsync(id) != null)
                    await repository.UpdateAsync(book);
        }

        public async Task Delete(Guid id)
        {
            if (id != null && id != Guid.Empty)
            {
                var book = await repository.GetByIdAsync(id);
                if (book != null)
                    await repository.RemoveAsync(book);
            }
        }
    }
}
