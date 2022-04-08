using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesSchedule.Models;

namespace RazorPagesSchedule.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //Added
        private readonly RazorPagesSchedule.Data.RazorPagesScheduleContext _context;

        public IndexModel(ILogger<IndexModel> logger, RazorPagesSchedule.Data.RazorPagesScheduleContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Event> AllEvents { get; set; }
        public IList<Event> FirstThree { get; set; }
        public async Task OnGetAsync()
        {
            var limitThree = (from m in _context.Event 
                              orderby m.Event_StartTime
                              where m.Event_StartTime.Date
                              >= DateTime.Now.Date
                              select m).Take(3);

            FirstThree = await limitThree.ToListAsync();
            //AllEvents = await _context.Event.ToListAsync();           
        }
        //new method
        public IList<Event> ScheduleMatchEntries(DateTime dt) 
        {
            var query = (from m in _context.Event
                         where m.Event_StartTime.Date.Equals(dt)
                         select m);
            return query.ToList();
        }
    }
}
