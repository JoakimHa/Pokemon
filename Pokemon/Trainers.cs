using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Trainers : NPC_s
    {
        private string _type;
        
        public Trainers(string name, int level, string type, int rewardMoney) : base(rewardMoney, name, level)
        {
            _name = name;
            _type = type;
            _level = level;
            _rewardMoney = rewardMoney;
            _pokemons = new List<Pokemon>();
        }
    }
}
