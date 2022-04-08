using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RazorPagesSchedule.Models;
using RazorPagesSchedule.wwwroot.cs;

namespace RazorPagesSchedule.Pages
{
    public class CalenderModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RazorPagesSchedule.Data.RazorPagesScheduleContext _context;
        public CalenderModel(ILogger<IndexModel> logger, RazorPagesSchedule.Data.RazorPagesScheduleContext context)
        {
            _logger = logger;
            _context = context;
        }
        public DateTime CalenderD { get; set; }
        //public IList<Event> AllEvents { get; set; }
        public void OnGet(string? time)
        {
            Console.WriteLine(time);
            if (time == null)
            {
                time = TimeUtils.DateToString(DateTime.Now);     
            } 
            CalenderD = TimeUtils.StringToDate(time);
            //AllEvents = await _context.Event.ToListAsync();
        }
        public IList<Event> ScheduleMatchEntries(DateTime dt)
        {
            var query = (from m in _context.Event
                         where m.Event_StartTime.Date.Equals(dt)
                         select m);
            return query.ToList();
        }
    }
}
