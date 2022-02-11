using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace Pokemon
{
    internal class GameBase1
    {
        public int EnemyAttackDamage;
        public string EnemyAttackName;
        public Player Player { get; set; }
        public Rival Rival { get; set; }

        Random random = new Random();
        public int CheckPoint;
        public GameBase1(Player player, Rival rival)
        {
            Player = player;
            Rival = rival;
            ChoosePokemon();
        }
        public void ChoosePokemon()
        {
            Console.Clear();
            Console.WriteLine("blah blah blah, choose your pokemon");
            Console.WriteLine(@"
C) Charmander, the fire type pokemon
B) Bulbasaur, the grass type pokemon
S) squirtle, the water type pokemon");
            
            var command = Console.ReadKey(true).KeyChar;
            Char.ToLower(command);
            switch (command)
            {
                case 'c':
                    Player._pokemons.Add(new Pokemon("Charmander", 5, 0, 20, 10, 1, Pokemon.Type.Fire, Pokemon.StatusEffect.None,
                        new Attack("scratch", Type.Normal, 40, 100, 35, 0, 0, 0, 0, 0, StatusEffect.None),
                        new Attack("Leer", Type.Normal, 0, 100, 30, 5, 0, 0, 0, 0, StatusEffect.None), 
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None),
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None)));
                    Rival._pokemons.Add(new Pokemon("Squirtle", 5, 0, 20, 10, 1, Pokemon.Type.Water, Pokemon.StatusEffect.None,
                        new Attack("tackle", Type.Normal, 40, 100, 35, 0, 0, 0, 0, 0, StatusEffect.None),
                        new Attack("growl", Type.Normal, 0, 100, 40, 0, 0, 0, 5, 0, StatusEffect.None), 
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None),
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None)));
                    break;
                case 'b':
                    Player._pokemons.Add(new Pokemon("Bulbasaur", 5, 0, 20, 10, 1, Pokemon.Type.Grass, Pokemon.StatusEffect.None,
                        new Attack("tackle", Type.Normal, 40, 100, 35, 0, 0, 0, 0, 0, StatusEffect.None),
                        new Attack("growl", Type.Normal, 0, 100, 40, 0, 0, 0, 5, 0, StatusEffect.None), 
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None),
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None)));
                    Rival._pokemons.Add(new Pokemon("Charmander", 5, 0, 20, 10, 1, Pokemon.Type.Fire, Pokemon.StatusEffect.None,
                            new Attack("scratch", Type.Normal, 40, 100, 35, 0, 0, 0, 0, 0, StatusEffect.None), 
                        new Attack("Leer", Type.Normal, 0, 100, 30, 5, 0, 0, 0, 0, StatusEffect.None), 
                            new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None),
                            new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None))); ;
                    break;
                case 's':
                    Player._pokemons.Add(new Pokemon("Squirtle", 5, 0, 20, 10, 1, Pokemon.Type.Water, Pokemon.StatusEffect.None,
                        new Attack("tackle", Type.Normal, 40, 100, 35, 0, 0, 0, 0, 0, StatusEffect.None), 
                        new Attack("growl", Type.Normal, 0, 100, 40, 0, 0, 0, 5, 0, StatusEffect.None), 
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None),
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None)));
                    Rival._pokemons.Add(new Pokemon("Bulbasaur", 5, 0, 20, 10, 1, Pokemon.Type.Grass, Pokemon.StatusEffect.None,
                        new Attack("tackle", Type.Normal, 40, 100, 35, 0, 0, 0, 0, 0, StatusEffect.None),
                        new Attack("growl", Type.Normal, 0, 100, 40, 0, 0, 0, 5, 0, StatusEffect.None), 
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None),
                        new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None)));
                    break;
                default:
                    ChoosePokemon();
                    break;
            }
            Game();
        }
        public void Game()
        {
            Console.Clear();
            Console.WriteLine("You wake up in your room. You go down stairs and greet your mother");
            Console.ReadKey(true);
            Console.WriteLine($"MOM: good morning {Player._name}");
            Console.ReadKey(true);
            Console.WriteLine($"MOM: your friend {Rival._name} came by and told me to tell you to come by his house");
            Console.ReadKey(true);
            Console.WriteLine("");
            Console.ReadKey(true);
            Console.WriteLine($"You go to {Rival._name}'s house");
            Console.ReadKey(true);
            Console.WriteLine($"{Rival._name}: HEY {Player._name}, BLAH BLAH BLAH What pokemon did you choose?");
            Console.ReadKey(true);
            Console.WriteLine($"YOU: {Player._pokemons[0]._name}");
            Console.ReadKey(true);
            Console.WriteLine($"{Rival._name}: Oh i chose {Rival._pokemons[0]._name}, guess ill be at an advantage!");
            Console.ReadKey(true);
            Console.WriteLine("YOU: lets find out. Lets battle!");
            Console.ReadKey(true);
            BattleRivalSetup1();
        }

        private void BattleRivalSetup1()
        {
            var PlayerPokemonIndex = 0;
            var RivalPokemonIndex = 0;
            Console.Clear();
            Console.WriteLine($"{Rival._name} Challenged you to a battle!");
            Console.ReadKey(true);
            Console.WriteLine($"{Rival._name} sent out {Rival._pokemons[RivalPokemonIndex]._name}");
            Console.ReadKey(true);
            Console.WriteLine($"{Player._name}: GO {Player._pokemons[PlayerPokemonIndex]._name}!");
            Console.ReadKey(true);
            battleRival1(PlayerPokemonIndex, RivalPokemonIndex);
            
        }
        public void battleRival1(int Pindex, int Rindex) {
            var CurrentPlayerPokemon = Player._pokemons[Pindex];
            var CurrentRivalPokemon = Rival._pokemons[Rindex];
            var gameInProgress = true;
            while (gameInProgress)
            {
                Console.Clear();
                Console.WriteLine($"Rival Current HP: {CurrentRivalPokemon._health}");
                Console.WriteLine($"Your Current HP: {CurrentPlayerPokemon._health}");
                Console.WriteLine("What will you do?");
                Console.WriteLine(@"1) Attack    (2 Pokemon
3) Items    4) Run");
                var Command = Console.ReadKey(true).KeyChar;
                switch (Command)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine(
                            @$"1) {CurrentPlayerPokemon._attack1._AttackName}    2) {CurrentPlayerPokemon._attack2._AttackName}
3) {CurrentPlayerPokemon._attack3}    4) {CurrentPlayerPokemon._attack4}");
                        var attackCommand = Console.ReadKey(true).KeyChar;
                        switch (attackCommand)
                        {
                            case '1':
                                var Playerdamage = CurrentPlayerPokemon._attack1._AttackDamage /
                                    CurrentRivalPokemon._defence * CurrentPlayerPokemon._attack;
                                CurrentRivalPokemon._health -= Playerdamage;
                                Console.WriteLine($"{CurrentPlayerPokemon._name} used {CurrentPlayerPokemon._attack1._AttackName} and dealt {Playerdamage}");
                                Console.ReadKey(true);
                                if (random.Next(0, 3) == 0)
                                {
                                    var rivalDamage = CurrentRivalPokemon._attack1._AttackDamage /
                                                      CurrentPlayerPokemon._defence;
                                    CurrentPlayerPokemon._health -= rivalDamage;
                                    
                                    Console.WriteLine($"{CurrentRivalPokemon._name} used {CurrentRivalPokemon._attack1._AttackName} and dealt {rivalDamage}");
                                    Console.ReadKey(true);
                                }
                                else
                                {
                                    Console.WriteLine($"{CurrentRivalPokemon._name} used {CurrentRivalPokemon._attack2._AttackName}! Your attack was slightly lowered");
                                    CurrentPlayerPokemon._attack -= CurrentRivalPokemon._attack2._attackDown / 100;
                                    Console.ReadKey(true);
                                }

                                break;
                            case '2':
                                CurrentRivalPokemon._defence -= CurrentPlayerPokemon._attack2._defenceDown;
                                if (random.Next(0, 3) == 0)
                                {
                                    var rivalDamage = CurrentRivalPokemon._attack1._AttackDamage /
                                                      CurrentPlayerPokemon._defence;
                                    CurrentPlayerPokemon._health -= rivalDamage;

                                    Console.WriteLine($"{CurrentRivalPokemon._name} used {CurrentRivalPokemon._attack1._AttackName} and dealt {rivalDamage}");
                                    Console.ReadKey(true);
                                }
                                else
                                {
                                    Console.WriteLine($"{CurrentRivalPokemon._name} used {CurrentRivalPokemon._attack2._AttackName}! Your attack was slightly lowered");
                                    CurrentPlayerPokemon._attack -= CurrentRivalPokemon._attack2._attackDown / 100;
                                    Console.ReadKey(true);
                                }

                                break;
                            case '3':
                                Console.WriteLine("No attack here yet");
                                Console.ReadKey(true);
                                break;
                            case '4':
                                Console.WriteLine("no attack here yet");
                                Console.ReadKey(true);
                                break;
                        }
                        Console.ReadKey(true);
                        break;
                    case '2':
                        Console.WriteLine("you have only one pokemon");
                        Console.ReadKey(true);
                        break;
                    case '3':
                        Console.WriteLine("You have no items yet");
                        Console.ReadKey(true);
                        break;
                    case '4':
                        Console.WriteLine("Cannot run from a trainer battle");
                        Console.ReadKey(true);
                        break;

                }
                if (CurrentPlayerPokemon._health <= 0)
                {
                    gameInProgress = false;
                    Console.WriteLine($"Your {CurrentPlayerPokemon._name} Fainted! You lost and gave $5 to the winner");
                    Console.ReadKey(true);
                    Console.Clear();
                    Game();
                } else if (CurrentRivalPokemon._health <= 0)
                {
                    Console.WriteLine($"{CurrentRivalPokemon._name} fainted! You won and gained {Rival._rewardMoney} and 10 exp!");
                    Player._pokemons[Pindex]._exp += 10;
                    Rival._rewardMoney = 100;
                    Console.ReadKey(true);
                    CheckPoint = 1;
                    Game2();
                }
            }
        }

        private void Game2()
        { 
            Console.Clear();
           Console.WriteLine($"{Rival._name}: How did you do that!? I clearly had the advantage!");
           Console.ReadKey(true);
            Console.WriteLine("YOU: lets pass it up as 'beginners luck'");
           Console.ReadKey(true);
           Console.WriteLine($"{Rival._name}: sounds good to me. We should hurry to the next town over, i heard that the gym there is only opened for a limited time!");
           Console.ReadKey(true);
            Console.WriteLine("PHONE: BRRR BRRRR, BRRR BRRRR");
           Console.ReadKey(true);
            Console.WriteLine($"MOM: Hey {Player._name}, come back home i forgot to give you something");
           Console.ReadKey(true);
            Console.WriteLine("YOU: go ahead, ill meet you there, i have to go home because mom wants to give me something");
           Console.ReadKey(true);
            Console.WriteLine($"{Rival._name}: Ok ill meet you there!");
           Console.ReadKey(true);
            Console.WriteLine("you go home");
           Console.ReadKey(true);
            Console.Clear();
           Console.WriteLine($"MOM: Hey {Player._name}, BLAH BLAH BLAH now get out there!");
           Console.ReadKey(true);
            Console.Clear();
           Console.WriteLine("Your adventure starts!");
           Console.ReadKey(true);
            Console.WriteLine("You begin heading to the next town, you see 2 paths, one through a big patch of grass and one clear of grass");
           Console.ReadKey(true);
            Console.WriteLine("which do you choose?");
           Console.WriteLine("1) Grass, 2) Clear road");
           var command = Console.ReadKey(true).KeyChar;
           switch (command)
           {
                case '1':
                    var FindPokemon = random.Next(1, 20);
                    if (FindPokemon <= 13)
                    {
                        FindRandomPokemon(1);
                    }
                    break;
           }
        }

        private void FindRandomPokemon(int level)
        {
            var pidgey = random.Next(0, 10);
            if (level == 1 /*&& pidgey <= 5*/)
            {
                var lvl = random.Next(1, 7);
                var EnemyPidgey = new Pokemon("pidgey", lvl, 0, 20 + lvl / 2, 10 + lvl / 2, 1, Pokemon.Type.Normal, Pokemon.StatusEffect.None,
                    new Attack("peck", Type.Flying, 35, 100, 35, 0, 0, 0, 0, 0, StatusEffect.None), 
                    new Attack("growl", Type.Normal, 0, 100, 40, 0, 0, 0, 5, 0, StatusEffect.None), 
                    new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None),
                    new Attack("none", Type.Normal, 0, 0, 0, 0, 0, 0, 0, 0, StatusEffect.None));
                Fight(EnemyPidgey, true);
            } 
        }
        internal void Fight(Pokemon Opponent, bool isWild)
        {

            var currentPokemon = Player._pokemons[0];
            var CurrentAttacker = currentPokemon;
            bool InFight = true;
            Console.Clear();
            if (isWild)
            {
                
                    Console.WriteLine($"A Wild {Opponent._name} Appeared!");
                Console.WriteLine($"YOU: GO {currentPokemon._name}!");
                Console.ReadKey(true);
                while (InFight)
                {
                    CurrentAttacker = currentPokemon;
                    Console.WriteLine($"{Opponent._name} HP: {Opponent._health}");
                Console.WriteLine($"{currentPokemon._name} HP: {currentPokemon._health}");
                Console.WriteLine(@$"What will you do?
1) Fight    2) Pokemon
3) Items    4) Run");
                var command = Console.ReadKey(true).KeyChar;
                switch (command)
                {
                        case '1':
                            fightMenu(currentPokemon, Opponent, CurrentAttacker);
                            break;
                        case '2':

                            break;
                        case '3':
                            break;
                        case '4':
                            var run = random.Next(0, 21);
                            if (run <= 15)
                            {
                                InFight = false;
                                CheckPoint += 1;
                                returnToCheckPoint(CheckPoint);
                            }
                            else
                            {
                                Console.WriteLine("didnt get away");
                                Console.ReadKey(true);
                            }
                            break;

                }

                GetRandomAttack();
                }

            } else if (!isWild)
            {

            }
        }

        private void GetRandomAttack()
        {
            
        }

        internal void fightMenu(Pokemon currentPokemon, Pokemon Opponent, Pokemon CurrentAttacker)
        {
            Console.WriteLine("what will you do?");
            Console.WriteLine($@"1){currentPokemon._attack1._AttackName}    2){currentPokemon._attack2._AttackName}
3){currentPokemon._attack3._AttackName}    4){currentPokemon._attack4._AttackName}");
            var command = Console.ReadKey(true).KeyChar;
            Attack currentAttack;
            switch (command)
            {
                case '1':
                    currentAttack = currentPokemon._attack1;
                    CalculateAttack(currentAttack, currentPokemon, Opponent, CurrentAttacker);
                    CurrentAttacker = Opponent;
                    break;
                case '2':
                    currentAttack = currentPokemon._attack2;
                    CalculateAttack(currentAttack, currentPokemon, Opponent, CurrentAttacker);
                    CurrentAttacker = Opponent;
                    break;
                case '3':
                    currentAttack = currentPokemon._attack3;
                    CalculateAttack(currentAttack, currentPokemon, Opponent, CurrentAttacker);
                    CurrentAttacker = Opponent;
                    break;
                case '4':
                    currentAttack = currentPokemon._attack4;
                    CalculateAttack(currentAttack, currentPokemon, Opponent, CurrentAttacker);
                    CurrentAttacker = Opponent;
                    break;
                default:
                    fightMenu(currentPokemon, Opponent, CurrentAttacker);
                    break;
            }
        }

        private void CalculateAttack(Attack currentAttack, Pokemon currentPokemon, Pokemon Opponent, Pokemon CurrentAttacker)
        {
            if (CurrentAttacker == currentPokemon)
            {
                var currentAttackDamage = currentAttack._AttackDamage / Opponent._defence;
                Opponent._health -= currentAttackDamage;
                Opponent._attack -= currentAttack._attackDown / 100;
                Opponent._defence -= currentAttack._defenceDown / 100;
                Opponent._effect = (Pokemon.StatusEffect)currentAttack._effect;
                CurrentAttacker = Opponent;
            }
            else
            {
                var currentAttackDamage = currentAttack._AttackDamage / currentPokemon._defence;
                currentPokemon._health -= currentAttackDamage;
                currentPokemon._attack -= currentAttack._attackDown / 100;
                currentPokemon._defence -= currentAttack._defenceDown / 100;
                currentPokemon._effect = (Pokemon.StatusEffect)currentAttack._effect;
                CurrentAttacker = currentPokemon;
            }

            if (currentPokemon._health <= 0)
            {
                
                returnToCheckPoint(CheckPoint);
            } 
            else if (Opponent._health <= 0)
            {
                CheckPoint += 1; 
                returnToCheckPoint(CheckPoint);
            }
        }

        private void returnToCheckPoint(int checkpoint)
        {
            if (checkpoint == 1)
            {
                Game2();
            }
            else if (checkpoint == 2)
            {
                Game3();
            }

        }
        private void Game3()
        {
            Environment.Exit(0);
        }
    }
}