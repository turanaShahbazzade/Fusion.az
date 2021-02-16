using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.Models
{
    public class AppUser:IdentityUser
    {  

        [Required, StringLength(15)]
        public string Name { get; set; }
        [Required, StringLength(20)]
        public string Surname { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }

    }
}
