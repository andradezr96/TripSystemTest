using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO.Catalogs.Clients
{
    public class DTOClient
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string ComercialName { get; set; }
        public string Rfc { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
