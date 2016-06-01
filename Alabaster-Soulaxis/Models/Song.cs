using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alabaster_Soulaxis.Models {
    public class Song {
        public string Title { get; set; }
        public string Singer { get; set; }
        public IEnumerable<string> Genre { get; set; }
        public string Lyrics { get; set; }
        public string StorageId { get; set; }
    }
}