using EatForHealth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EatForHealth.DBContext
{
    public class EFHDbContext : DbContext
    {
        public EFHDbContext() : base("DBEatForHealth")
        { }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}