using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameJamAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Team> Team { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public bool ActiveSub { get; set; }
        public string Description { get; set; }
        public string Rules { get; set; }
        public string Theme { get; set; }
        
    }
}