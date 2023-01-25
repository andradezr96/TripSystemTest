using Microsoft.AspNetCore.Mvc;
using Models.DTO.Common;
using Services.Common.Catalogs.Drivers;
using System.Collections.Generic;
using TripSystemTest.Controllers.CRUD;

namespace TripSystemTest.Controllers.Common
{
    public class OptionsController : AppBaseController
    {
        [Route("drivers")]
        public List<DTOOption> GetCustomOptions([FromServices] IDriverService driverService) => driverService.GetDriversOptions();
    }
}
