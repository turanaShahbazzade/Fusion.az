using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        public string  Icon { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(200)]
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }

    }
}
