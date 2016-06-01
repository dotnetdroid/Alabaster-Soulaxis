using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alabaster_Soulaxis.Models {
    public class Assignment {
        public string ScheduleId { get; set; }
        public Person Person { get; set; }
        public string AssignmentId { get; set; }
        public string Role { get; set; }
    }
}