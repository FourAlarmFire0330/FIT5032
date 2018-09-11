using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EatForHealth.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The username cannot be null!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "The length must be {2} to {1}")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The password cannot be null!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Not a Valid email Address")]
        [Required(ErrorMessage = "Email cannot be null!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please choose your Gender!")]
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
    }
}