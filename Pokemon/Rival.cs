using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Rival : NPC_s
    {
        public string _name;
        

        public Rival(string name, int level, int RewardMoney) : base(RewardMoney, name, level)
        {
            _rewardMoney = RewardMoney;
            _name = name;
        }
    }
}
