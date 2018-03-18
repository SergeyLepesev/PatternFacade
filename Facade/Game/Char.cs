namespace Facade.Game
{
    public abstract class Char
    {
        public abstract string Name { get; }
        protected SettingsDamage _settingsDamage;
        public int Health => _settingsDamage.Health;
        public int Mana => _settingsDamage.Mana;
        public int Damage => _settingsDamage.Damage;

        public abstract void Init();
    }
}