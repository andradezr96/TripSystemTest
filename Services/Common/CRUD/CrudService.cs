using DataAccess.Repositories.CRUD;
using Models.DTO.Common;
using Models.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Common.CRUD
{
    public abstract class CrudService<T, TDTO, TRepository, TSM> : ICrudService<T, TDTO, TSM>
        where T : LoggeableEntity where TDTO : class where TRepository : ICrudRepository<T, TDTO, TSM>
        where TSM : SMBase
    {
        protected readonly TRepository repository;

        protected CrudService(TRepository repository)
        {
            this.repository = repository;
        }

        public virtual async Task<T> CreateAndGet(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            repository.Add(entity);
            return entity;
        }

        public virtual async Task Delete(int id)
        {
            T entity = GetById(id);
            repository.Delete(entity);
        }

        public virtual List<TDTO> GetAll()
        {
            return this.repository.GetAll();
        }

        public virtual T GetById(int id)
        {
            return repository.FindById(id); 
        }

        public DTOPaginatedList<TDTO> List(TSM searchModel)
        {
            var list = repository.ListPaginated(searchModel);
            return list;
        }

        public virtual async Task<T> Update(T entity)
        {
            entity.UpdatedAt = DateTime.Now;
            repository.Update(entity);

            return entity;
        }
    }
}
