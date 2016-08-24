using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemoRefactored2
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldForKill = 1023;

            Console.WriteLine("You have killed the Giant IE6 Monster and gained {0} gold!", goldForKill);

            var joe = new Person { Name = "Joe", GoldCoins = 1000 };
            var jake = new Person { Name = "Jake" };
            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };
            var brian = new Person { Name = "Brian", GoldCoins = 2000 };

            var oldBod = new Person { Name = "OldBod"};
            var newBod = new Person { Name = "NewBod" };

            var bobs = new Group { Name = "The Bobs", Members = { oldBod, newBod } };

            var developers = new Group { Name = "Developers", Members = { joe, jake, emily, bobs } };

            var parties = new Group { Members = { developers, sophia, brian } };

            parties.GoldCoins = goldForKill;
            parties.Stats();

            Console.WriteLine("Group {0} has a total of {1} gold coins", developers.Name, developers.GoldCoins);
            System.Console.ReadKey();
        }
    }
}