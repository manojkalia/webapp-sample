using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace SampleApp.Core.Abstraction
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        IQueryable<T> All { get; }

        IQueryable<T> GetAll { get; }

        IEnumerable<T> Find(Func<T, bool> predicate);

        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

        T Find(int id);

        void InsertOrUpdate(T entity);

        void InsertOrUpdate(IEnumerable<T> entities);

        void InsertWithId(T entity);

        void Update(T entity);

        void Update(IEnumerable<T> entities);

        void Insert(T entity);

        void Insert(IEnumerable<T> entities);

        void Delete(int id);

        void Save();

        IQueryable<T> GetFiltered(Expression<Func<T, bool>> filter);

        void DbContextConfigurationAutoDetectChangesEnable();

        void DbContextConfigurationAutoDetectChangesDisable();

        IQueryable<T> GetAllAsNoTracking(params Expression<Func<T, object>>[] includeProperties);
    }
}
