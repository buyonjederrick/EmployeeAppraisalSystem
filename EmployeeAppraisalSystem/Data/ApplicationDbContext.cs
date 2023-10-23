using EmployeeAppraisalSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace EmployeeAppraisalSystem.Data
{
    // The ApplicationDbContext class represents the database context for the Employee Appraisal System.
    // It inherits from Entity Framework Core's DbContext class and is responsible for defining the database schema
    // and managing interactions with the database.

    public class ApplicationDbContext : DbContext
    {
        // Constructor for the ApplicationDbContext, which takes DbContextOptions as a parameter.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // This constructor is used to configure the database context with the provided options.
        }

        // DbSet properties define the database tables that correspond to the specified entity types.
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<AppraisalPeriod> AppraisalPeriods { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Appraisal> Appraisals { get; set; }

        // The OnModelCreating method is overridden to define the database schema and relationships.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring the relationship between Objective and Appraisal entities.
            modelBuilder.Entity<Objective>()
                .HasMany(o => o.Appraisals)
                .WithOne(a => a.Objective)
                .OnDelete(DeleteBehavior.NoAction);

            // Configuring the relationship between Appraisal and Objective entities.
            modelBuilder.Entity<Appraisal>()
                .HasOne(a => a.Objective)
                .WithMany(o => o.Appraisals)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
