using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.Catalogs.Trips;
using Models.DTO.Common;
using Models.Entities.Catalogs.Trips;
using Services.Common.Catalogs;
using System.Threading.Tasks;
using TripSystemTest.Controllers.CRUD;

namespace TripSystemTest.Controllers.Catalogs
{
    public class TripController : CrudController<Trip, DTOTrip, ITripService, SMTrip>
    {
        public TripController(ITripService service, IMapper mapper) : base(service, mapper)
        {
        }

        public override Task<IActionResult> PutAsync([FromBody] DTOTrip dto)
        {
            return base.PutAsync(dto);
        }

        public override Task<IActionResult> DeleteAsync(int id)
        {
            return base.DeleteAsync(id);
        }

        public override Task<IActionResult> PostAsync([FromBody] DTOTrip dto)
        {
            return base.PostAsync(dto);
        }

        public override DTOPaginatedList<DTOTrip> List([FromQuery] SMTrip searchModel)
        {
            return base.List(searchModel);
        }
    }
}
