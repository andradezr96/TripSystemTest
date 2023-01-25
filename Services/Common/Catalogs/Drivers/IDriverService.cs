using Models.DTO.Catalogs.Drivers;
using Models.DTO.Common;
using Models.Entities.Catalogs.Drivers;
using Services.Common.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Common.Catalogs.Drivers
{
    public interface IDriverService: ICrudService<Driver, DTODriver, SMDriver>
    {
        public List<DTOOption> GetDriversOptions();

    }
}
