using DataAccess.Repositories.Catalogs.Drivers;
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
    public class DriverService : CrudService<Driver, DTODriver, IDriverRepository, SMDriver>, IDriverService
    {
        public DriverService(IDriverRepository repository) : base(repository)
        {
        }

        public List<DTOOption> GetDriversOptions()
        {
            return this.repository.GetDriversOptions();
        }
    }
}
