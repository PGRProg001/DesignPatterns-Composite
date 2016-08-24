using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo
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
           
            var individuals = new List<Person> { sophia, brian };
            var groups = new List<Group> { developers };

            var totalToSplitBy = individuals.Count + groups.Count;

            var amountForEach = goldForKill / totalToSplitBy;
            var leftOver = goldForKill % totalToSplitBy;

            foreach(var individual in individuals)
            {
                individual.GoldCoins = amountForEach + leftOver;
                leftOver = 0;
            }

            var amountForEachGroup = amountForEach / groups.Count;
            foreach(var group in groups)
            {
                var leftOverForGroup = amountForEachGroup % group.Members.Count;
                foreach(var member in group.Members)
                {
                    member.GoldCoins = amountForEachGroup / group.Members.Count + leftOverForGroup;
                    leftOverForGroup = 0;
                }
            }

            foreach (var individual in individuals)
               individual.Stats();

            foreach (var group in groups)
            {
                Console.WriteLine("Group : {0}", group.Name);
                foreach (var member in group.Members)
                {
                    member.Stats();
                }
            }
            System.Console.ReadKey();
        }
    }
}
