using InspectionAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)  : base(options) { }

        public DbSet<Inspection> Inspections { get; set; }

        public DbSet<InspectionType> InspectionTypes { get; set; }

        public DbSet<Status> Statuses { get; set; }
        public DbSet<Company> CompanyRepo { get; set; }
        public DbSet<Person> PersonRepo { get; set; }
        public DbSet<Plan> PlanRepo { get; set; }
        public DbSet<Project> ProjectRepo { get; set; }

        
    }
}
