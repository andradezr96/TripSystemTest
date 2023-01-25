using AutoMapper;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Models.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using AutoMapper.QueryableExtensions;

namespace DataAccess.Repositories.CRUD
{
    public abstract class CrudRepository<T, TDTO, TSM> : Repository<T>, ICrudRepository<T, TDTO, TSM>
        where TDTO : class
        where T : class
        where TSM : SMBase
    {
        protected CrudRepository(TripSystemContext context, IMapper mapper) : base(context, mapper)
        {
        }

       
        public List<TDTO> GetAll()
        {
            return this.GetQueryable().ProjectTo<TDTO>(this.mapper.ConfigurationProvider).ToList();
        }

        public List<TDTO> List(TSM searchModel)
        {
            IQueryable<T> list = GetElementsInOrder(searchModel);
            list = FilterQueryable(searchModel, ref list);
            return list.ProjectTo<TDTO>(mapper.ConfigurationProvider).ToList();
        }
        public virtual DTOPaginatedList<TDTO> ListPaginated(TSM searchModel)
        {
            IQueryable<T> list = GetElementsInOrder(searchModel).AsNoTracking();
            list = FilterQueryable(searchModel, ref list);
            IQueryable<T> listPaginated = list.Skip(searchModel.Page * searchModel.PageSize).Take(searchModel.PageSize);
            return new DTOPaginatedList<TDTO>
            {
                Data = listPaginated.ProjectTo<TDTO>(mapper.ConfigurationProvider).ToList(),
                ResultsLength = list.Count()
            };
        }
        protected virtual IQueryable<T> GetElementsInOrder(TSM searchModel)
        {
            return GetOrderableQueryable(searchModel.OrderCriteria);
        }
        protected IQueryable<T> GetOrderableQueryable(string columnOrderExpression, Expression<Func<T, bool>> filter = null,
            List<Expression<Func<T, object>>> columns = null)
        {
            return GetQueryable(filter, null, columns).OrderBy(columnOrderExpression);
        }
        protected abstract IQueryable<T> FilterQueryable(TSM searchModel, ref IQueryable<T> list);

        protected virtual List<TDTO> ProjectToDTO(IQueryable<T> entities)
        {
            return entities.ProjectTo<TDTO>(mapper.ConfigurationProvider).ToList();
        }
    }
}
