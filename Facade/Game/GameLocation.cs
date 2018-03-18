namespace Facade.Game
{
    public abstract class GameLocation
    {
        public abstract string Name { get; }
        public int CountEnemies { get; protected set; }

        public abstract void Init(DifficultyGame difficulty);
    }
}