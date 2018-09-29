using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EatForHealth.Models
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeID { get; set; }

        [Required(ErrorMessage = "Not null")]
        public string RecipeName { get; set; }

        [Required(ErrorMessage = "Not null")]
        public string RecipeDesc { get; set; }
    }
}