using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSchedule.Models
{
    public class Event
    {
        public int ID { get; set; }
        public String Description { get; set; }

        [Display(Name="Start Time")]
        public DateTime Event_StartTime { get; set; }

        [Display(Name = "End Time")]
        public DateTime Event_EndTime { get; set; }
        public bool Occuring { get; set; }
    }
}
