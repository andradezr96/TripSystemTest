using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO.Catalogs.Drivers
{
    public class DTODriver
    {
        public int DriverId { get; set; }
        public string DriverNumber { get; set; }

        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string LicenseNumber { get; set; }

        public string IsActive { get; set; }
    }
}
