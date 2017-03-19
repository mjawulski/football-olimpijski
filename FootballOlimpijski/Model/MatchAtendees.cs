using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballOlimpijski.Model
{
    public class MatchAtendees
    {
        public int MatchId { get; set; }
        public int UserId { get; set; }

        public Match Match { get; set; }
        public User User { get; set; }
    }
}
