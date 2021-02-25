using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string GeneralQuestion { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
