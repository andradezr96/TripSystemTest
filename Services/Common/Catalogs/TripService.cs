using DataAccess.Repositories.Catalogs.Trips;
using Models.DTO.Catalogs.Trips;
using Models.Entities.Catalogs.Trips;
using Services.Common.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Common.Catalogs
{
    public class TripService : CrudService<Trip, DTOTrip, ITripRepository, SMTrip>, ITripService
    {
        public TripService(ITripRepository repository) : base(repository)
        {
        }
    }
}
