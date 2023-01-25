using AutoMapper;
using DataAccess.Context;
using DataAccess.Repositories.CRUD;
using Models.DTO.Catalogs.Trips;
using Models.Entities.Catalogs.Trips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Catalogs.Trips
{
    public class TripRepository : CrudRepository<Trip, DTOTrip, SMTrip>, ITripRepository
    {
        public TripRepository(TripSystemContext context, IMapper mapper) : base(context, mapper)
        {
        }

        protected override IQueryable<Trip> FilterQueryable(SMTrip searchModel, ref IQueryable<Trip> list)
        {
            if(!string.IsNullOrEmpty(searchModel.Search))
            {
                list = list.Where(a => a.Origin.ToLower().Contains(searchModel.Search.ToLower())
                        || a.Destiny.ToLower().Contains(searchModel.Search.ToLower())
                        || a.Driver.FirstName.ToLower().Contains(searchModel.Search.ToLower())
                        || a.Driver.LastName.ToLower().Contains(searchModel.Search.ToLower())
                        || a.Driver.Name.ToLower().Contains(searchModel.Search.ToLower())
                        || a.TripId.ToString().Contains(searchModel.Search.ToLower())
                        );
            }
            return list;
        }
    }
}
