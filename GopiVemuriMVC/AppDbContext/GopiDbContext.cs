using GopiVemuriMVC.BOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GopiVemuriMVC.AppDbContext
{
    public class GopiDbContext : DbContext
    {
        public GopiDbContext()
        {
            Database.Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
            Database.SetInitializer<GopiDbContext>(null);
        }

        public DbSet<UserBO> UserBOs { get; set; }
    }
}