using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCL.Repository.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        int GetTotalRowCount { get; }
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(int offSet, int rowCount);
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
