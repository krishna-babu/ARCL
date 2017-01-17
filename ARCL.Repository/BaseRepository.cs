using ARCL.DBModel;
using ARCL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCL.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ARCLContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(ARCLContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public virtual IQueryable<T> GetAll(int offSet, int rowCount)
        {
            return _dbSet.Skip(offSet).Take(rowCount).AsQueryable();
        }

        public virtual int GetTotalRowCount
        {
            get
            {
                return _dbSet.Count();
            }
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable<T>();
        }

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.SetModified(entity);
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }

    }

}
