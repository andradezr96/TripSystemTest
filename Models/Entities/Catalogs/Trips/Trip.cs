using Models.Entities.Catalogs.Clients;
using Models.Entities.Catalogs.Drivers;
using Models.Entities.Common;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Catalogs.Trips
{
    [Table("trip")]
    public class Trip: LoggeableEntity
    {
        [Column("trip_id")]
        public int TripId { get; set; }
        [Column("origin")]
        public string Origin { get; set; }
        [Column("destiny")]
        public string Destiny { get; set; }

        [Column("driver_id")]
        public int DriverId { get; set; }
        [Column("initial_date")]
        public DateTime InitialDate { get; set; }
        [Column("final_date")]
        public DateTime FinalDate { get; set; }
        [Column("status")]
        public TripStatus Status { get; set; }

        public Driver Driver { get; set; }
        public Client Client { get; set; }
        
    }
}
