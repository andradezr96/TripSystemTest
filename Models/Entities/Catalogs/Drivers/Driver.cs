using Models.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Catalogs.Drivers
{
    [Table("driver")]
    public class Driver : LoggeableEntity
    {
        [Column("driver_id")]
        public int DriverId { get; set; }
        [Column("driver_number")]
        public string DriverNumber { get; set; }

        [Column("name")]
        public string Name { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }

        [Column("license_number")]
        public string LicenseNumber { get; set; }

        [Column("is_active")]
        public string IsActive { get; set; }



    }
}
