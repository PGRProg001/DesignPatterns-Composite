using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemoRefactored2
{
    public class Person : IParty
    {
        public string Name { get; set; }
        private int _goldCoins = 0;

        public int GoldCoins {
            get { return _goldCoins; }
            set { _goldCoins = value; } 
        }

        public void Stats()
        {
            Console.WriteLine("{0} has {1} gold coins", Name, GoldCoins);
        }
    }
}
