using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemoRefactored1
{
    public class Person : Party
    {
        public string Name { get; set; }
        public int GoldCoins { get; set; }

        public void Stats()
        {
            Console.WriteLine("{0} has {1} gold coins.", Name, GoldCoins);
        }
    }
}
