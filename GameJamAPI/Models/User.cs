using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameJamAPI.Models
{
    public class User : ApplicationUser
    {
        public ICollection<Team> Teams { get; set; }
        public string Specialty { get; set; }
    }
}