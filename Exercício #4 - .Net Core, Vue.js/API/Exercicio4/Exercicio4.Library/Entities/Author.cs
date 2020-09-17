using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Library.Entities
{
    public class Author
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }
}
