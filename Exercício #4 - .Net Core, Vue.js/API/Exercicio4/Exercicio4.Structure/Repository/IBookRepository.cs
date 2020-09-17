using Exercicio4.Library.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exercicio4.Data.Structure.Repository
{
    public interface IBookRepository
    {
        /// <summary>
        /// Insert record book
        /// </summary>
        /// <param name="book">Book model</param>
        /// <returns></returns>
        Task InsertAsync(Book book);
        /// <summary>
        /// Update book model
        /// </summary>
        /// <param name="book">Book model</param>
        /// <returns></returns>
        Task UpdateAsync(Book book);
        /// <summary>
        /// Remove book record
        /// </summary>
        /// <param name="book">Book model</param>
        /// <returns></returns>
        Task RemoveAsync(Book book);
        /// <summary>
        /// Get Book by Id
        /// </summary>
        /// <param name="id">Book id</param>
        /// <returns>Return book model</returns>
        Task<Book> GetByIdAsync(Guid id);
        /// <summary>
        /// List all books saved
        /// </summary>
        /// <returns>Return all books</returns>
        Task<List<Book>> GetAllAsync();
    }
}
