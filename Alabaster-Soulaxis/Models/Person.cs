using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alabaster_Soulaxis.Models {
    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
    
}