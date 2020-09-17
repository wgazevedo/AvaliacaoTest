using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Library.Entities
{
    public class Book
    {
        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual Guid IdAuthor { get; set; }
        public virtual int Stock { get; set; }
    }
}
