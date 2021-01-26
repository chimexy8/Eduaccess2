using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationAccess.Models
{
    public class SponsorSignUpViewModel
    {
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

       
        public string Company { get; set; }

        [Required]
        public string Phone { get; set; }
        [Required]
        public string Role { get; set; }

        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-.]).{8,}$", ErrorMessage = "Password must contain at least 8 characters,one uppercase,one lowercase,one special character and one numeric character")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
