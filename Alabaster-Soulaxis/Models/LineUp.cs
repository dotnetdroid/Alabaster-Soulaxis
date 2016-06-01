using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alabaster_Soulaxis.Models {
    public class Lineup {
        public IEnumerable<Song> Songs { get; set; }
        public string Theme { get; set; }
    }
}