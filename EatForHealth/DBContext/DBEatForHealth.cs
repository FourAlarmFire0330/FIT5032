using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EatForHealth.Models;
using System.Data.Entity;

namespace EatForHealth.DBContext
{
    public class DBEatForHealth:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}