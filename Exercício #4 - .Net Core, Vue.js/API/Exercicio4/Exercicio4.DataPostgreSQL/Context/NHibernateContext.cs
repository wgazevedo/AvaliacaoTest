using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.DataPostgreSQL.Context
{
    public class NHibernateContext<T>
    {
        private readonly ISession _session;
        private ITransaction _trans;

        protected NHibernateContext(ISession session)
        {
            _session = session;
        }

        public IQueryable<T> Query => _session.Query<T>();

        protected async Task Commit()
        {
            await _trans.CommitAsync();
        }

        protected async Task Rollback()
        {
            await _trans.RollbackAsync();
        }

        protected void CloseTransaction()
        {
            if (_trans != null)
            {
                _trans.Dispose();
                _trans = null;
            }
        }

        protected async Task Save(T entity)
        {
            await _session.SaveOrUpdateAsync(entity);
        }

        protected async Task Delete(T entity)
        {
            await _session.DeleteAsync(entity);
        }
    }
}
