using Microsoft.EntityFrameworkCore;
using MyCompany.Models;

namespace MyCompany.Data
{
    public class MyCompanyContext : DbContext
    {
        public MyCompanyContext(DbContextOptions<MyCompanyContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Job)
                .WithMany(j => j.Employees)
                .HasForeignKey(e => e.JobID);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentID);
        }
    }
}
