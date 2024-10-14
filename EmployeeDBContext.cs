using Microsoft.EntityFrameworkCore;
namespace CRUDUsingQueryAJAX.Models
{
    public class EmployeeDBContext : DbContext
    {

       // Constructor calling the Base DbContext Class Constructor
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext>options) : base(options)
        {
        }

        // OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        // Adding Domain Classes as DbSet Properties
        public DbSet<Employee> Employees { get; set; }

    }
}