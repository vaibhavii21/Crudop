using Microsoft.EntityFrameworkCore;
using Crudop.Models;
using System.Reflection;

namespace Crudop.Data
{ 
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> StudentTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 3, Name = "Reena", Gender = "Female", Age = 15, PhoneNo = 758865700, Birthday = 2402 },
                new Student { Id = 4, Name = "Savi", Gender = "Female", Age = 27, PhoneNo = 854963705, Birthday = 3105 },
                new Student{ Id = 5, Name = "Ishan", Gender = "male", Age = 32, PhoneNo = 793658946, Birthday = 2012 },
               new Student { Id = 6, Name = "Suresh", Gender = "male", Age = 50, PhoneNo = 154289653, Birthday = 1403 },
               new Student { Id = 9, Name = "Rani", Gender = "Female", Age = 99, PhoneNo = 832987458, Birthday = 2408 });
        }
    }


}
