using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Pokemon
    {
       public enum Type
        {
            Fire,
            Grass,
            Water,
            Flying,
            Normal,
        }
       public enum StatusEffect
       {
           Sleeping,
           Poisoned,
           Paralyzed,
           None,
       }
        public  string _name;
        public  int _level;
        public int _exp;
        public  double _health;
        public  double _defence;
        public  double _attack;
        public  Type _type;
        public StatusEffect _effect;
        public Attack _attack1;
        public  Attack _attack2;
        public  Attack _attack3;
        public  Attack _attack4;
        

        public Pokemon(string name, int level, int exp, double health, double defence, double attack, Type type, StatusEffect effect, Attack attack1, Attack attack2, Attack attack3, Attack attack4)
        {
            _name = name;
            _level = level;
            _exp = exp;
            _health = health;
            _defence = defence;
            _attack = attack;
            _type = type;
            _effect = effect;
            _attack1 = attack1;
            _attack2 = attack2;
            _attack3 = attack3;
            _attack4 = attack4;
        }
    }
}
