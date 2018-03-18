using System;

namespace Facade.Game.Enemy
{
    public class WildMan : Char
    {
        public override string Name => "WildMan";
        public override void Init()
        {
            var rnd = new Random();
            _settingsDamage = new SettingsDamage()
            {
                Health = rnd.Next(DateTime.Now.Hour),
                Mana = rnd.Next(DateTime.Now.Minute),
                Damage = rnd.Next(DateTime.Now.Millisecond)
            };
        }
    }
}