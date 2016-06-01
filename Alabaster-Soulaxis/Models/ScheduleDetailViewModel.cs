using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alabaster_Soulaxis.Models {
    public class ScheduleDetailViewModel {
        public Lineup Lineup { get; set; }
        public IEnumerable<Assignment> Singers { get; set; }
        public IEnumerable<Assignment> Band { get; set; }
        public IEnumerable<Assignment> Others { get; set; }
        public Schedule Schedule { get; set; }
    }
}