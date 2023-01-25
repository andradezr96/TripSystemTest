using Models.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.CRUD
{
    public interface ICrudRepository<T, TDTO, TSM> : IRepository<T>
        where T : class
        where TDTO : class
        where TSM : SMBase
    {
        List<TDTO> List(TSM searchModel);
        List<TDTO> GetAll();
        DTOPaginatedList<TDTO> ListPaginated(TSM searchModel);

    }
}
