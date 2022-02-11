using System;
using System.Collections.Generic;

namespace Pokemon
{
    internal class Program
    {


        static void Main(string[] args)
        {
            setup();
        }

        public static void setup()
        {
            Console.WriteLine("what is your name");
            var Name = Console.ReadLine();
            var Player = new Player(Name, 0, 100);
            Console.WriteLine($"{Name} huh? Your friend came by a few minutes ago, what was his name again?");
            var FriendName = Console.ReadLine();
            Console.WriteLine($"oh yeah {FriendName}, thats what it was.");
            var Rival = new Rival(FriendName, 1, 25);
            Console.ReadKey(true);
            Console.WriteLine("Welcome to the world of pokemon, im professor Redwood");
            Console.ReadKey(true);
            var Gamebase1 = new GameBase1(Player, Rival);
            
        }
    }
}

