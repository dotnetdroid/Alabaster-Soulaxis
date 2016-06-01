using Alabaster_Soulaxis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Alabaster_Soulaxis.Controllers {
    [AllowAnonymous]
    public class ScheduleController : ApiController {
        public IEnumerable<string> GetSchedules() {
            return new List<string> {
               new DateTime(2016, 01, 03).ToLongDateString(),
               new DateTime(2016, 01, 10).ToLongDateString(),
               new DateTime(2016, 01, 17).ToLongDateString(),
               new DateTime(2016, 01, 24).ToLongDateString(),
               new DateTime(2016, 01, 31).ToLongDateString(),
               new DateTime(2016, 02, 07).ToLongDateString(),
               new DateTime(2016, 02, 14).ToLongDateString(),
               new DateTime(2016, 02, 21).ToLongDateString(),
               new DateTime(2016, 02, 28).ToLongDateString(),
           };
        }

        public ScheduleDetailViewModel GetDetails(string scheduleId) {
            var bandLeader = new Person {
                FirstName = "Randy",
                LastName = "Dinglasan",
                Roles = new List<string> { "Basist", "Guitarist" }
            };

            var worshipLeader = new Person {
                FirstName = "Marlyn",
                LastName = "Basa",
                Roles = new List<string> { "Singer" }
            };

            var schedule = new Schedule {
                WorshipLeader = worshipLeader,
                BandLeader = bandLeader,
                Id = Guid.NewGuid().ToString(),
                ScheduleDate = new DateTime(2016, 12, 13),
                Type = "Sunday Service",
                Multimedia = new Person {
                    FirstName = "Jam",
                    LastName = "Macasling",
                },
                SoundTechnician = new Person {
                    FirstName = "Neil",
                    LastName = "Dizon"
                }
            };

            var songs = new List<Song> {
                new Song { Title = "Rooftops", Singer = "Jesus Culture" },
                new Song { Title = "I Will Search", Singer = "Israel & New Breed" },
                new Song { Title = "Forever Reign", Singer = "Hillsong Worship" },
            };

            var band = new List<Assignment> {
                new Assignment {
                    AssignmentId = Guid.NewGuid().ToString(),
                    Person = new Person {
                        FirstName = "Jake",
                        LastName = "Roxas",
                        Roles = new List<string> { "Guitar", "Basist" , "Singer" }
                    },
                    Role = "(Guitar)"
                },
                new Assignment {
                    AssignmentId = Guid.NewGuid().ToString(),
                    Person = new Person {
                        FirstName = "Henry",
                        LastName = "Pacis",
                        Roles = new List<string> { "Keyboardist" }
                    },
                    Role = "(Main Keys)"
                },
                new Assignment {
                    AssignmentId = Guid.NewGuid().ToString(),
                    Person = new Person {
                        FirstName = "Charist",
                        LastName = "Dizon",
                        Roles = new List<string> { "Keyboardist" }
                    },
                    Role = "(Second Keys)"
                },
                new Assignment {
                    AssignmentId = Guid.NewGuid().ToString(),
                    Person = new Person {
                        FirstName = "Randy",
                        LastName = "Dinglasan",
                        Roles = new List<string> { "Basist", "Guitarist" }
                    },
                    Role = "(Basist)"
                },
                new Assignment {
                    AssignmentId = Guid.NewGuid().ToString(),
                    Person = new Person {
                        FirstName = "Dina",
                        LastName = "Antonio",
                        Roles = new List<string> { "Drummer" }
                    },
                    Role = "(Drummer)"
                },
            };

            var singers = new List<Assignment> {
                 new Assignment {
                    AssignmentId = Guid.NewGuid().ToString(),
                    Person = new Person {
                        FirstName = "Peace",
                        LastName = "Adraincem",
                        Roles = new List<string> { "Singer" }
                    },
                    Role = "(Soprano)"
                },

                new Assignment {
                    AssignmentId = Guid.NewGuid().ToString(),
                    Person = new Person {
                        FirstName = "Aizel",
                        LastName = "Ebreo",
                        Roles = new List<string> { "Singer" }
                    },
                    Role = "(Alto)"
                },

                new Assignment {
                    AssignmentId = Guid.NewGuid().ToString(),
                    Person = new Person {
                        FirstName = "Khaye",
                        LastName = "Abines",
                        Roles = new List<string> { "Singer" }
                    },
                    Role = "(Melody)"
                },

                new Assignment {
                    AssignmentId = Guid.NewGuid().ToString(),
                    Person = new Person {
                        FirstName = "Randy",
                        LastName = "Aguilar",
                        Roles = new List<string> { "Singer" }
                    },
                    Role = ""
                },
            };

            return new ScheduleDetailViewModel {
                Lineup = new Lineup {
                    Songs = songs,
                    Theme = "God's Sovereignty",
                },
                Band = band,
                Singers = singers,
                Schedule = schedule
            };
        }
    }
}
