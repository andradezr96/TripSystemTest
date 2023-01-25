using Models.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Catalogs.Clients
{
    [Table("client")]
    public class Client:LoggeableEntity
    {
        [Column("client_id")]
        public int ClientId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("comercial_name")]
        public string ComercialName { get; set; }
        [Column("rfc")]
        public string Rfc { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("address")]
        public string Address { get; set; }
    }
}
