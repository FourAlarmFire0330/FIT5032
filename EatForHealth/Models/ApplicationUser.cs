using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatForHealth.Models
{
    public class ApplicationUser : IdentityUser
    {
        //External Attribute
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
    }
}