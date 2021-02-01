using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.Models
{
    public class FunFact
    {
        public int Id { get; set; }
        [Required] 
        public string Icon { get; set; }
        [Required]
        public int Number { get; set; }
        [Required, StringLength(50)]
        public string Title { get; set; }
    }
}
