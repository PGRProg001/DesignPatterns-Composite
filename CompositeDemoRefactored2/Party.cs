using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDemoRefactored2
{
    public interface IParty
    {
        string Name { get; set; }
        int GoldCoins { get; set; }
        void Stats();
    }
}
