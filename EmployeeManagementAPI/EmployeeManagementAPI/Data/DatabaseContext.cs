using Microsoft.EntityFrameworkCore;
using EmployeeManagementAPI.Models.Entities;

namespace EmployeeManagementAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
