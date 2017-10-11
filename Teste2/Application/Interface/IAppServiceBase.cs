using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void AddMany(IEnumerable<TEntity> list);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
