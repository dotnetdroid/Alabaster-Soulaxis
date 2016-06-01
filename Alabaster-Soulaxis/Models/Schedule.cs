using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alabaster_Soulaxis.Models {
    public class Schedule {
        public string Id { get; set; }
        public string Type { get; set; }
        public DateTime ScheduleDate { get; set; }
        public Person WorshipLeader { get; set; }
        public Person BandLeader { get; set; }
        public Person Multimedia { get; set; }
        public Person SoundTechnician { get; set; }
    }
}