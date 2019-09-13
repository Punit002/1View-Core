using Microsoft.EntityFrameworkCore;

namespace MyFirstApplication
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
           : base(options)
        {
        }

        public DbSet<EmployeeInfo> employees { get; set; }
    }
}
