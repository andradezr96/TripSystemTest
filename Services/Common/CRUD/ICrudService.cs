using Models.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Common.CRUD
{
    public interface ICrudService<T, TDTO, TSM> where T : class
        where TDTO: class
        where TSM : SMBase
    {
        T GetById(int id);

        Task<T> CreateAndGet(T entity);

        Task<T> Update(T entity);

        Task Delete(int id);

        List<TDTO> GetAll();
        DTOPaginatedList<TDTO> List(TSM searchModel);
    }
}
