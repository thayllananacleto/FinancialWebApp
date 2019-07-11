using Finance.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Finance.DAO
{
    public class FinanceContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Actions> Actions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actions>().HasRequired(a => a.User);
        }

    }
}