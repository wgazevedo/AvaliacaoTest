using Exercicio4.Library.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exercicio4.Data.Structure.Repository
{
    public interface IAuthorRepository
    {
        /// <summary>
        /// Insert recorde Author
        /// </summary>
        /// <param name="author">Model Author</param>
        /// <returns></returns>
        Task InsertAsync(Author author);
        /// <summary>
        /// Update recorde Author
        /// </summary>
        /// <param name="author">Model Author</param>
        /// <returns></returns>
        Task UpdateAsync(Author author);
        /// <summary>
        /// Remove recorde Author
        /// </summary>
        /// <param name="author">Model Author</param>
        /// <returns></returns>
        Task RemoveAsync(Author author);
        /// <summary>
        /// Get Author by id
        /// </summary>
        /// <param name="id">Id Author</param>
        /// <returns>retorn Model Author</returns>
        Task<Author> GetByIdAsync(Guid id);
        /// <summary>
        /// List All records Author
        /// </summary>
        /// <returns>Return All Authors Saved</returns>
        Task<List<Author>> GetAllAsync();
    }
}
