using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemoRefactored1
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldForKill = 1023;
            Console.WriteLine("You have killed the Giant IE6 Monster and gained {0} gold!", goldForKill);

            var joe = new Person { Name = "Joe" };
            var jake = new Person { Name = "Jake" };
            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };
            var brian = new Person { Name = "Brian" };

            var developers = new Group { Name = "Developers", Members = { joe, jake, emily } };

            var parties = new List<Party> { developers, sophia, brian };

            var totalToSplitBy = parties.Count;

            var amountForEach = goldForKill / totalToSplitBy;
            var leftOver = goldForKill % totalToSplitBy;

            foreach (var partyMember in parties)
            {
                partyMember.GoldCoins += amountForEach + leftOver;
                leftOver = 0;
            }

            foreach (var partyMember in parties)
            {
                partyMember.Stats();
            }

            System.Console.ReadKey();
        }
    }
}
