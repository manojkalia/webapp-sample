using SampleApp.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SampleApp.DAL
{
    
    public class SampleRepository<T> : IEntityRepository<T>
        where T : class, IEntity
    {
        #region  Fields

        private readonly SampleContext _context ;
        private readonly DbSet<T> _dbSet;

        #endregion

        #region Methods

        private T FindAsNoTracking(int id)
        {
            return _dbSet.Find(id);
        }

        public SampleRepository(SampleContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> All
        {
            get { return _dbSet.ToList().AsQueryable(); }
        }

        public IQueryable<T> GetAll
        {
            get { return _dbSet.AsQueryable(); }
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _dbSet.ToList().AsQueryable();

            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _dbSet.AsQueryable();

            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public void InsertOrUpdate(T entity)
        {
            if (IsExistable(entity))
            {
                // New entity
                _dbSet.Add(entity);
            }
            else
            {
                // Existing entity
                var updateEntity = FindAsNoTracking(entity.Id);

                if (updateEntity != null)
                {
                    var attachEntry = _context.Entry(updateEntity);
                    attachEntry.CurrentValues.SetValues(entity);
                }
                else
                {
                    _context.Entry(entity).State = EntityState.Modified;
                }
            }
        }

        public void Update(T entity)
        {
            var updateEntity = FindAsNoTracking(entity.Id);

            if (updateEntity != null)
            {
                var attachEntry = _context.Entry(updateEntity);
                attachEntry.CurrentValues.SetValues(entity);
            }
            else
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Update(IEnumerable<T> entities)
        {
            ((List<T>)entities).ForEach(Update);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Insert(IEnumerable<T> entities)
        {
            ((List<T>)entities).ForEach(Insert);
        }

        public void InsertOrUpdate(IEnumerable<T> entities)
        {
            ((List<T>)entities).ForEach(InsertOrUpdate);
        }

        public void InsertWithId(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool IsExist(int id)
        {
            return _dbSet.Select(x => new { x.Id }).FirstOrDefault(x => x.Id == id) != null;
        }

        private bool IsExistable(T entity)
        {
            var databaseGeneratedOptionIsNone = typeof(T)
                .GetProperty("Id")
                .GetCustomAttributes(typeof(DatabaseGeneratedAttribute), true)
                .Cast<DatabaseGeneratedAttribute>()
                .SingleOrDefault(x => x.DatabaseGeneratedOption == DatabaseGeneratedOption.None) != null;

            return (databaseGeneratedOptionIsNone && (entity.Id != default(int) && !IsExist(entity.Id))) || entity.Id == default(int);
        }

        public IQueryable<T> GetFiltered(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter);
        }

        public IQueryable<T> GetAllAsNoTracking(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _dbSet.AsNoTracking().AsQueryable();

            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public void DbContextConfigurationAutoDetectChangesEnable()
        {
            _context.Configuration.AutoDetectChangesEnabled = true;
        }

        public void DbContextConfigurationAutoDetectChangesDisable()
        {
            _context.Configuration.AutoDetectChangesEnabled = false;
        }

        #endregion
    }
}
