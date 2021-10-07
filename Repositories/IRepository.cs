namespace SampleSite.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using SampleSite.Models.Entities;

    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entity);
        TEntity GetById(int id);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        int Count();
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Dispose();
    }
}
