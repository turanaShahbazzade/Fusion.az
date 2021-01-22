using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.Models
{
    public class Bio
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        [Required, StringLength(200)]
        public string Address { get; set; }
        [Required, StringLength(200)]
        public string WebAddress { get; set; }
        [Required, StringLength(25)]
        public string  Phone { get; set; }
        [Required, StringLength(100)]
        public string OpenMonFri { get; set; }
        [Required, StringLength(100)]
        public string OpenSat { get; set; }
        [Required, StringLength(100)]
        public string Mail { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Whatsapp { get; set; }

    }
}
