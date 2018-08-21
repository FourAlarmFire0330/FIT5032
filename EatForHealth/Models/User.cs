using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatForHealth.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Career { get; set; }
        public char Gender { get; set; }
        public DateTime DoB { get; set; }
        public string ProfilePicture { get; set; }
    }
}