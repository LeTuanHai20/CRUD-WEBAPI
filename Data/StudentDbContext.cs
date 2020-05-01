using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIdemo.Models;

namespace WebAPIdemo.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                    new Student() { ID = 1, Name = "Tuan Hai", Class = "KTPM3" },
                    new Student() { ID = 2, Name = "Tuan Chung", Class = "KTPM1" },
                    new Student() { ID = 3, Name = "Tuan Anh", Class = "KTPM2" },
                    new Student() { ID = 4, Name = "Tuan Tung", Class = "KTPM3" },
                    new Student() { ID = 5, Name = "Tuan Tu", Class = "KTPM1" }
                );
        }
    }
}
