using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Player
    {
        public List<Pokemon> _pokemons;
        public string _name;
        public int _badges;
        public int _money;
        public Player(string name, int badges, int money)
        {
            _name = name;
            _badges = badges;
            _money = money;
            _pokemons = new List<Pokemon>();
        }
    }
}
