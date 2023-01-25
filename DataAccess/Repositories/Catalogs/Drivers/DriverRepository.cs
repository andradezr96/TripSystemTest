using AutoMapper;
using AutoMapper.QueryableExtensions;
using DataAccess.Context;
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
    public class DriverRepository : CrudRepository<Driver, DTODriver, SMDriver>, IDriverRepository
    {
        public DriverRepository(TripSystemContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public List<DTOOption> GetDriversOptions()
        {
            return this.GetQueryable().ProjectTo<DTOOption>(this.mapper.ConfigurationProvider).ToList();
        }


        protected override IQueryable<Driver> FilterQueryable(SMDriver searchModel, ref IQueryable<Driver> list)
        {
            throw new NotImplementedException();
        }
    }
}
