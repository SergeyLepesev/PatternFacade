namespace Facade.Game
{
    public abstract class Location
    {
        public abstract string Name { get; }
        public abstract int CountEnemies { get; }

        public abstract void Init(DifficultyGame difficulty);
    }
}