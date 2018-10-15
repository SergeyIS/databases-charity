using System;
using System.Data.Entity;
using Overview.Models;

namespace Overview
{
    class DataContext : DbContext
    {
        public DataContext(String conn) : base(conn) { }

        public DbSet<User> Users { get; set; }

        public DbSet<UserCredentials> Credentials { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("EF_TEST");
        }
    }
}
