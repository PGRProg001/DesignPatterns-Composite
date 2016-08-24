using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemoRefactored2
{
    public class Group : IParty
    {
        public string Name { get; set; }
        public List<IParty> Members { get; set; }

        public Group()
        {
            Members = new List<IParty>();
        }

        public int GoldCoins
        {
            get
            {
                int totalGoldCoins = 0;
                foreach (var member in Members)
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
                    /* there must be a distinction between a group and person otherwise
                       there will be members of the group will be assigned the total 
                     * number of gold coins the group has and the number of goldCoins to 
                     * be assigned.  The original solution did not cater for this.
                     * The is prevalent when a user has an initial amount of goldCoins 
                     * which is none zero.
                     */
                    
                    
                    if (member.GetType() == typeof(Group))
                        member.GoldCoins = memberGoldCoins + leftOverForGroup;
                    else
                        member.GoldCoins += memberGoldCoins + leftOverForGroup;

                    leftOverForGroup = 0;
                }                
            }
        }

        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }          
        }
    }
}
