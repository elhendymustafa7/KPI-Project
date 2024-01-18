global using Microsoft.EntityFrameworkCore;
global using KPI.Data.Models;
global using KPI.Data;

namespace KPI.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Kpi> KPIs { get; set; }
    }
}
