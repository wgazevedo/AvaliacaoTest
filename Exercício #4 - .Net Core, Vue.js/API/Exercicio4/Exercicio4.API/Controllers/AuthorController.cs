using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio4.Business.Components;
using Exercicio4.Library.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exercicio4.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorComponent component;

        [HttpGet]
        public async Task<IEnumerable<Author>> GetAsync() => await component.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<Author> GetAsync(Guid id) => await component.GetByIdAsync(id);

        [HttpPost]
        public void Post([FromBody] Author author) => component.Insert(author);

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Author author) => component.Update(id, author);

        [HttpDelete("{id}")]
        public void Delete(Guid id) => component.Delete(id);
    }
}
