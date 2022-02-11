using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class GymLeaders : NPC_s
    {
        public GymLeaders(string name, int badgeNr, int rewardMoney, string TMReward, int level) :base(rewardMoney, name, level)
        {

        }
    }
}
