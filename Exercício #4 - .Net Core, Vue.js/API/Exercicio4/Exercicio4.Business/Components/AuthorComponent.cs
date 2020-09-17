using Exercicio4.Data.Structure.Repository;
using Exercicio4.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.Business.Components
{
    public class AuthorComponent
    {
        private readonly IAuthorRepository _repository;

        public AuthorComponent(IAuthorRepository repository)
        {
            _repository = repository;
        }

        public async Task<Author> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task Insert(Author author)
        {
            await _repository.InsertAsync(author);
        }

        public async Task Update(Guid id, Author author)
        {
            if (id != null && id != Guid.Empty)
                if (await _repository.GetByIdAsync(id) != null)
                    await _repository.UpdateAsync(author);
        }

        public async Task Delete(Guid id)
        {
            if (id != null && id != Guid.Empty)
            {
                var author = await _repository.GetByIdAsync(id);
                if (author != null)
                    await _repository.RemoveAsync(author);
            }
        }
    }
}
