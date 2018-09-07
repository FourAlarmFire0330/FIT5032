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

        public string Career { get; set; }

        [Required(ErrorMessage = "Please choose your Gender!")]
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
    }
}