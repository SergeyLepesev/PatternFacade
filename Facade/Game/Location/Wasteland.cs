namespace Facade.Game.Location
{
    public class Wasteland:GameLocation
    {
        public override string Name => "Wasteland";
        private const int MinCountEnemies = 222;
        public override void Init(DifficultyGame difficulty)
        {
            switch (difficulty)
            {
                case DifficultyGame.Low:
                    CountEnemies = MinCountEnemies;
                    break;
                case DifficultyGame.Medium:
                    CountEnemies = MinCountEnemies * 2;
                    break;
                case DifficultyGame.Hard:
                    CountEnemies = MinCountEnemies * 3;
                    break;
            }
        }
    }
}