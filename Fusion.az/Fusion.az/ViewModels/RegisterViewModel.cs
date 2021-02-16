using Fusion.az.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.ViewModels
{
    public class RegisterViewModel
    {

        public string UserName { get; set; }
        [Required, StringLength(15)]
        public string Name { get; set; }
        [Required, StringLength(25)]
        public string Surname { get; set; }
        [Required(ErrorMessage ="The Phone field required")]
        public string PhoneNumber { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage="The Repeat Password field is required"), DataType(DataType.Password), Compare(nameof(Password), ErrorMessage ="Passwords do not match"),]
        public string RepeatPassword { get; set; }
        public Bio Bio { get; set; }

    }
}
