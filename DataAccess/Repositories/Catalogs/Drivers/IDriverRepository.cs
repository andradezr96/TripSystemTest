using DataAccess.Repositories.CRUD;
using Models.DTO.Catalogs.Drivers;
using Models.DTO.Common;
using Models.Entities.Catalogs.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Catalogs.Drivers
{
    public interface IDriverRepository : ICrudRepository<Driver, DTODriver, SMDriver>
    {
        List<DTOOption> GetDriversOptions();
    }
}
