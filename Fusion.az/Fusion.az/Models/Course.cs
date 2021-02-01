using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, StringLength(60)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; } 
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
       

        
    }
}
