using Microsoft.EntityFrameworkCore;
using SchedulerApp.Models;

namespace SchedulerApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Events> Events { get; set; }
    }
}
