using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class NPC_s
    {
        public int _rewardMoney;
        protected int _level;
        protected string _name;
        public List<Pokemon> _pokemons;
        public NPC_s(int RewardMoney, string name, int level)
        {
            _pokemons = new List<Pokemon>();
        }
    }
}
