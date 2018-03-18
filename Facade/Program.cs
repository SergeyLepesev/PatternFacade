using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Facade.Game;
using Facade.Game.Character;
using Facade.Game.Enemy;
using Facade.Game.Location;
using Char = Facade.Game.Char;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            InitGame();
            //initializing another
            Console.ReadKey();
        }

        public static void InitGame()
        {
            var facade = new Facade(
                new Wasteland(),
                new List<Char>
                {
                    new SuperMax(),
                    new WildMan()
                },
                DifficultyGame.Low
                );
            facade.InitChars();
            facade.InitLocation();
        }
    }
}
