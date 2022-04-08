using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesSchedule.Data;
using System;
using System.Linq;

namespace RazorPagesSchedule.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesScheduleContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesScheduleContext>>()))
            {
                if (context.Event.Any()) {
                    return;     //DB has been seeded
                }
                /*
                context.Event.AddRange(
                    new Event
                    {
                        Description = "Eagle Watching",
                        Event_StartTime = DateTime.Parse("2021-10-5 11:30 AM"),
                        Event_EndTime = DateTime.Parse("2021-10-5 1:00 PM"),
                        Occuring = false
                    }
                );
                context.SaveChanges();
                */
            }
        }
    }
}
