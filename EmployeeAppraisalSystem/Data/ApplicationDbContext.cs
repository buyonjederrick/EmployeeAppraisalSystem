using EmployeeAppraisalSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace EmployeeAppraisalSystem.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<AppraisalPeriod> AppraisalPeriods { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Appraisal> Appraisals { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Objective>()
                .HasMany(o => o.Appraisals)
                .WithOne(a => a.Objective)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Appraisal>()
                .HasOne(a => a.Objective)
                .WithMany(o => o.Appraisals)
                .OnDelete(DeleteBehavior.NoAction);
        }


    }
}
