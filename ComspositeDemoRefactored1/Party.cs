using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDemoRefactored1
{
    internal interface Party
    {
        int GoldCoins { get; set; }
        void Stats();
    }
}
