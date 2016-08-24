using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo
{
    public class Person
    {
        public string Name { get; set; }
        public int GoldCoins { get; set; }

        public void Stats()
        {
            Console.WriteLine("{0} has {1} gold coins.", Name, GoldCoins);
        }
    }
}
