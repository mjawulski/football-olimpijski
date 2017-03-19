using FootballOlimpijski.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballOlimpijski.ExtensionMethods
{
    public static class FootballContextExtensionMethods
    {
        public static void SeedData(this FootballContext context)
        {
            if (!context.Matches.Any())
            {
                Match finalMatch = new Match() { Date = DateTime.Now, Venue = "Old Trafford" };
                context.Matches.Add(finalMatch);
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                User ronaldo = new User() { Username = "Ronaldo", AvatarUrl = "http://www.avatarsdb.com/avatars/ronaldo.jpg" };
                User zidane = new User() { Username = "Zidane", AvatarUrl = "http://www.avatarsdb.com/avatars/zinedine_zidane.jpg" };
                context.Users.AddRange(zidane, ronaldo);
                context.SaveChanges();
            }

            if (!context.Attendees.Any())
            {
                MatchAtendees ma = new MatchAtendees() { MatchId = 1, UserId = 1 };
                MatchAtendees ma2 = new MatchAtendees() { MatchId = 1, UserId = 2 };
                context.Attendees.AddRange(ma, ma2);
                context.SaveChanges();
            }
        }
    }
}
