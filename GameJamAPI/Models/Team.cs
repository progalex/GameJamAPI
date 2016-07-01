using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameJamAPI.Models
{
    public class Team
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public ICollection<User> Members { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}