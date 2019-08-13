using Microsoft.EntityFrameworkCore;
using Sourcer;
using System.Configuration;

namespace Server.Connection
{
    public class idszContext : DbContext
    {
        public idszContext(DbContextOptions<idszContext> options) : base(options)
        {

        }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Flunt api ord_bah. 
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Lee",
                    LastName = "John"
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Lee",
                    LastName = "YueHan"
                });
        }
    }
}
