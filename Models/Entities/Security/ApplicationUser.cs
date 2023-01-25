using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Security
{
    public class ApplicationUser: IdentityUser
    {
        [Column("name"), Required]
        public string Name { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("phone_number"), Required, StringLength(10)]
        public string PhoneNumber { get; set; }


    }
}
