using Microsoft.EntityFrameworkCore;

namespace Scheduler.Models
{
    public class SchedulerContext : DbContext
    {
        public SchedulerContext(DbContextOptions<SchedulerContext> options)
            : base(options)
        {
        }

        public DbSet<SchedulerItem> SchedulerItems { get; set; }
        public DbSet<Address> AddresseSets { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
    }
}
