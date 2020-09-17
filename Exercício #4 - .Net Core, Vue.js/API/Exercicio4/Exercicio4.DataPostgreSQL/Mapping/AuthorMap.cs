using Exercicio4.Library.Entities;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.DataPostgreSQL.Mapping
{
    public class AuthorMap : ClassMapping<Author>
    {
        public AuthorMap()
        {
            Id(x => x.Id, x =>
            {
                x.Generator(Generators.Guid);
                x.Type(NHibernateUtil.Guid);
                x.Column("Id");
                x.UnsavedValue(Guid.Empty);
            });

            Property(b => b.Name, x =>
            {
                x.Length(200);
                x.Type(NHibernateUtil.StringClob);
                x.NotNullable(true);
            });

            Table("Authors");
        }
    }
}
