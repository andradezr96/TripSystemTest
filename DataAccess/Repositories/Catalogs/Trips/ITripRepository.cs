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
    public interface ITripRepository: ICrudRepository<Trip,DTOTrip, SMTrip>
    {
    }
}
