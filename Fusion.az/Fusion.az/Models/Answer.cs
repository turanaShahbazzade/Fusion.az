﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.Models
{
    public class Answer
    {
        public int Id { get; set; }
        [Required]
        public string GeneralAnswer { get; set; } 
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
