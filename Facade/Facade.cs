using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Facade.Game;
using Char = Facade.Game.Char;

namespace Facade
{
    public class Facade
    {
        private readonly GameLocation _location;
        private readonly IEnumerable<Char> _chars;
        private readonly DifficultyGame _difficulty;

        public Facade(GameLocation location, IEnumerable<Char> chars, DifficultyGame difficulty)
        {
            _location = location;
            _chars = chars;
            _difficulty = difficulty;
        }

        public Task InitLocation()
        {
            return Task.Run(() => _location.Init(_difficulty));
        }

        public Task InitChars()
        {
            return Task.Run(() =>
            {
                foreach (var item in _chars)
                {
                    item.Init();
                }
            });
        }

    }
}