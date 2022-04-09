﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesSchedule.Data.RazorPagesScheduleContext _context;

        public DetailsModel(RazorPagesSchedule.Data.RazorPagesScheduleContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
