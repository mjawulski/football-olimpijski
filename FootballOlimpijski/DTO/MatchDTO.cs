using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballOlimpijski.DTO
{
    public class MatchDTO
    {
        public int Id { get; set; }
        public string Venue { get; set; }
        public DateTime Date { get; set; }

        public IList<UserDTO> Atendees { get; set; }
    }
}
