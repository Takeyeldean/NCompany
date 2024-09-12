using Employee.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace Employee.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) { }
            
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionstring = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //   modelBuilder.ApplyConfiguration(new CourseConfiguration()); Not best practice
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

    }
}
