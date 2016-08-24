using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemoRefactored1
{
    public class Group : Party
    {
        public string Name { get; set; }
        public List<Person> Members { get; set; }
        public Group()
        {
            Members = new List<Person>();
        }

        public int GoldCoins
        {
            get 
            {
                int totalGoldCoins = 0;
                foreach(var member in Members)
                {
                    totalGoldCoins += member.GoldCoins;
                }
                return totalGoldCoins;
            }
            set
            {
                var memberGoldCoins = value / Members.Count;
                var leftOverForGroup = value % Members.Count;
                foreach (var member in Members)
                {
                    member.GoldCoins += memberGoldCoins + leftOverForGroup;
                    leftOverForGroup = 0;
                }
            }
        }

        public void Stats()
        {
            Console.WriteLine("Group : {0}", Name);
            foreach(var member in Members)
            {
                member.Stats();
            }

            Console.WriteLine("----------", Name);
        }
    }
}
