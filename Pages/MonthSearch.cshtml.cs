using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSchedule.Pages
{
    public class MonthSearchModel : PageModel
    {
        public int DesignatedMonth { get; set; }
        public int DesignatedYear { get; set; }
        public enum MonthNames
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        public void OnGet()
        {

        }
    }
}
