using Microsoft.EntityFrameworkCore;

namespace RazorPagesSchedule.Data
{
    public class RazorPagesScheduleContext : DbContext
    {
        public RazorPagesScheduleContext (DbContextOptions<RazorPagesScheduleContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesSchedule.Models.Event> Event { get; set; }
    }
}
