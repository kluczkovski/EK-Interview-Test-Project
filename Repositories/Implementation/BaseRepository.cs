namespace SampleSite.Repositories.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;
    using SampleSite.DbContext;
    using SampleSite.Models.Entities;

    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbContext context;

        public BaseRepository(SampleSiteDBContext sampleSiteDBContext)
        {
            this.context = sampleSiteDBContext;
        }

        public void Add(TEntity objModel)
        {
            this.context.Set<TEntity>().Add(objModel);
            this.context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> objModel)
        {
            this.context.Set<TEntity>().AddRange(objModel);
            this.context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return this.context.Set<TEntity>().Find(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return this.context.Set<TEntity>().FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            return this.context.Set<TEntity>().Where<TEntity>(predicate).ToList();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.context.Set<TEntity>().ToList();
        }

        public int Count()
        {
            return this.context.Set<TEntity>().Count();
        }

        public void Update(TEntity objModel)
        {
            this.context.Entry(objModel).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Remove(TEntity objModel)
        {
            this.context.Set<TEntity>().Remove(objModel);
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

    }
}
