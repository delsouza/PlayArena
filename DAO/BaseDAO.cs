using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAO.Interface;

namespace DAO
{
    public class BaseDAO<TEntidade> : IBaseDAO<TEntidade> where TEntidade : class
    {
        private readonly DbContext _db;

        public BaseDAO(DbContext db)
        {
            _db = db;
        }

        public IQueryable<TEntidade> ListarPor(Expression<Func<TEntidade, bool>> where, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            return Listar(includeProperties).Where(where);
        }

        public IQueryable<TEntidade> Listar(params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            IQueryable<TEntidade> query = _db.Set<TEntidade>();

            if (includeProperties.Any())
            {
                return Include(_db.Set<TEntidade>(), includeProperties);
            }

            return query;
        }

        public IQueryable<TEntidade> Listar()
        {
            IQueryable<TEntidade> query = _db.Set<TEntidade>();

            return query;
        }

        private IQueryable<TEntidade> Include(IQueryable<TEntidade> query, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }

            return query;
        }
    }
}


