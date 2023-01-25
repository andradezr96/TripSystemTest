using AutoMapper;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.CRUD
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TripSystemContext context;
        protected readonly IMapper mapper;
        protected readonly DbSet<T> dbSet;

        public Repository(TripSystemContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
            this.dbSet = context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        } 

        public virtual void AddRange(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
            context.SaveChanges();

        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
            this.context.SaveChanges();
        }

        public virtual void DeleteRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
            context.SaveChanges();

        }

        protected virtual IQueryable<T> GetQueryable(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<Expression<Func<T, object>>> columns = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (columns != null)
            {
                foreach (var includeProperty in columns)
                {
                    query = query.Include(includeProperty);
                }
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return query;
        }

        public virtual T FindById(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges(true);


        }

        public virtual IEnumerable<T> FindAll()
        {
            return this.GetQueryable().ToList();
        }
    }
}
