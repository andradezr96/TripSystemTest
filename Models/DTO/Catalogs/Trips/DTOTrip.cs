using Models.DTO.Catalogs.Clients;
using Models.DTO.Catalogs.Drivers;
using Models.Entities.Catalogs.Clients;
using Models.Entities.Catalogs.Drivers;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO.Catalogs.Trips
{
    public class DTOTrip
    {
        public int TripId { get; set; }
        public string Origin { get; set; }
        public string Destiny { get; set; }
        public string? TripNumber { get; set; }
        public string? DriverName { get; set; }

        public int DriverId { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public TripStatus Status { get; set; }

        //public DTODriver Driver { get; set; }
        //public DTOClient Client { get; set; }
    }
}
