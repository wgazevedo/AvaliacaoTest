using Exercicio4.DataPostgreSQL.Context;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.DataPostgreSQL.Repository
{
    public class BaseRepository<T> : NHibernateContext<T>
    {
        public BaseRepository(ISession session) : base(session)
        {
        }
    }
}
