using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameJamAPI.Models
{
    public class Game
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public ICollection<Award> Awards { get; set; }
    }
}