using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Data;
using Task_Management_Lib.Models;

namespace Task_Management_System.Repository
{
    public class Repository<TModel, TID> : IRepository<TModel, TID> where TModel : BaseModel<TID>
    {
        private readonly DbSet<TModel> _dbSet;
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TModel>();
        }

        public TModel Add(TModel entity)
        {
            return _context.Add(entity).Entity;
        }

        public IEnumerable<TModel> GetAll(Func<TModel, bool> filter = null, Func<TModel, TID> orderBy = null, string includeProps = null)
        {
            IQueryable<TModel> dbSet = _dbSet;
            if(filter != null)
            {
                dbSet = (IQueryable<TModel>)_dbSet.Where(filter);
            }

            if(orderBy != null)
            {
                dbSet = (IQueryable<TModel>)dbSet.OrderBy<TModel, TID>(orderBy);
            }

            if(includeProps != null)
            {
                string[] includeProps_arr = includeProps.Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach(var str in includeProps_arr)
                {
                    dbSet = dbSet.Include(str);
                }
            }
            return dbSet.ToList();
        }

        public TModel GetOne(Func<TModel, bool> filter, string includeProps = null)
        {
            IQueryable<TModel> dbSet = _dbSet;
            if (filter != null)
            {
                dbSet = (IQueryable<TModel>)_dbSet.Where(filter);
            }

            if (includeProps != null)
            {
                string[] includeProps_arr = includeProps.Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach (var str in includeProps_arr)
                {
                    dbSet = dbSet.Include(str);
                }
            }
            return dbSet.FirstOrDefault();
        }

        public void Remove(TModel entity)
        {
            _dbSet.Remove(entity);
        }

        public void Remove(TID id)
        {
            var entity = GetOne(m => m.Id.Equals(id));
            _dbSet.Remove(entity);
        }
    }
}
