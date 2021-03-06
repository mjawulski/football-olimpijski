﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballOlimpijski.Model
{
    public class Match
    {
        public int Id { get; set; }
        public string Venue { get; set; }
        public DateTime Date { get; set; }

        public ICollection<MatchAtendees> Atendees { get; set; }
    }
}
