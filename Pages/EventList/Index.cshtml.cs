using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesSchedule.Data;
using RazorPagesSchedule.Models;

namespace RazorPagesSchedule.Pages.EventList
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesSchedule.Data.RazorPagesScheduleContext _context;

        public IndexModel(RazorPagesSchedule.Data.RazorPagesScheduleContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();
        }
    }
}
