using Exercicio4.Library.Entities;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.DataPostgreSQL.Mapping
{
    public class BookMap : ClassMapping<Book>
    {
        public BookMap()
        {
            Id(x => x.Id, x =>
            {
                x.Generator(Generators.Guid);
                x.Type(NHibernateUtil.Guid);
                x.Column("Id");
                x.UnsavedValue(Guid.Empty);
            });

            Property(x => x.IdAuthor, x =>
            {
                x.Type(NHibernateUtil.Guid);
                x.Column("IdAuthor");
                x.NotNullable(false);
            });

            Property(b => b.Title, x =>
            {
                x.Length(200);
                x.Type(NHibernateUtil.StringClob);
                x.NotNullable(true);
                x.Column("Title");
            });

            Property(b => b.Stock, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.NotNullable(true);
                x.Column("Stock");
            });

            Table("Book");
        }
    }
}
