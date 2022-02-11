using System;

namespace Pokemon
{
    public enum Type
    {
        Fire,
        Normal,
        Flying,
    }

    public enum StatusEffect
    {
        Sleeping,
        Poisoned,
        Paralyzed,
        None,
    }
    public class Attack
    {
        
        public string _AttackName { get; set; }
        public Type _AttackType { get; set;}
        public int _AttackDamage { get; set;}
        public int _Accuracy { get; set;}
        public int _pp { get; set; }
        public int _defenceDown { get; set; }
        public int _defenceUp { get; set;}
        public int _attackUp { get; set; }
        public int _attackDown { get; set; }
        public int _healthUp { get; set; }
        public StatusEffect _effect { get; set; }


        public Attack(string attackName, Type attackType, int attackDamage, int accuracy, int pp, int defenceDown, int defenceUp, int attackUp, int attackDown, int healthUp, StatusEffect effect)
        {
            _AttackName = attackName;
            _AttackType = attackType;
            _AttackDamage = attackDamage;
            _Accuracy = accuracy;
            _pp = pp;
            _defenceDown = defenceDown;
            _defenceUp = defenceUp;
            _attackUp = attackUp;
            _attackDown = attackDown;
            _healthUp = healthUp;
            _effect = effect;
        }
    }
}