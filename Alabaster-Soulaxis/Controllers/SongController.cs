using Alabaster_Soulaxis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Alabaster_Soulaxis.Controllers
{
    public class SongController : ApiController
    {
        public List<Song> GetSongs() {
            var songs = new List<Song> {
                new Song {
                    Title = "I Will Sing",
                    Singer = "Israel & New Breed"
                },
                new Song {
                    Title = "From the Inside Out",
                    Singer = "Hillsong United"
                },
                new Song {
                    Title = "Mighty to save",
                    Singer = "Hillsong United"
                },
                new Song {
                    Title = "Call My Name",
                    Singer = "Third Day"
                },
                new Song {
                    Title = "Forever Reign",
                    Singer = "Hillsong Worship"
                },
                   new Song {
                    Title = "Victor's Crown",
                    Singer = "Darlene Zschech"
                },
                    new Song {
                    Title = "Great Are You Lord",
                    Singer = "All Sons & Daughters"
                },
                     new Song {
                    Title = "Jesus at the Center",
                    Singer = "Israel & New Breed"
                },
                      new Song {
                    Title = "Dakila",
                    Singer = "Himig ng Lahi"
                },
                new Song {
                    Title = "Isang Bagay",
                    Singer = "Himig ng Lahi"
                },
                new Song {
                    Title = "Ni Minsan",
                    Singer = "Himig ng Lahi"
                },
            };

            return songs;
        }

        public List<Song> GetCurrentLineup() {
            var songs = new List<Song> {
                 new Song {
                    Title = "Rooftops",
                    Singer = "Jesus Culture"
                },
                new Song {
                    Title = "I Will Sing",
                    Singer = "Israel & New Breed"
                },
                 new Song {
                    Title = "Forever Reign",
                    Singer = "Hillsong Worship"
                },
            };

            return songs;
        }

        public List<Song> GetFavorites() {
            var songs = new List<Song> {
                 new Song {
                    Title = "Isang Bagay",
                    Singer = "Himig ng Lahi"
                },
                new Song {
                    Title = "Ni Minsan",
                    Singer = "Himig ng Lahi"
                },
                new Song {
                    Title = "From the Inside Out",
                    Singer = "Hillsong United"
                },
                 new Song {
                    Title = "Call My Name",
                    Singer = "Third Day"
                },
                new Song {
                    Title = "Jesus at the Center",
                    Singer = "Israel & New Breed"
                },
            };

            return songs;
        }
    }
}
