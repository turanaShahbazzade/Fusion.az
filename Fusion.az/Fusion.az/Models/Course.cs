using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
      
        [NotMapped] 
        public IFormFile Photo { get; set; }
       
        [Required(ErrorMessage = "The name field is required"), StringLength(60)]
        public string Name { get; set; } 
       
       
        [Required(ErrorMessage = "The Description field is required")]
        public string Description { get; set; } 
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
       

        
    }
}
