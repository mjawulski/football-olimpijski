using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballOlimpijski.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string AvatarUrl { get; set; }

        public ICollection<MatchAtendees> Matches { get; set; }
    }
}
