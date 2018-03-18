using System;
using System.Data;

namespace Facade.Game.Character
{
    public class SuperMax : Char
    {
        public override string Name => "SuperMax";


        public override void Init()
        {
            _settingsDamage = new SettingsDamage
            {
                Health = DateTime.Now.Hour,
                Mana = DateTime.Now.Minute,
                Damage = DateTime.Now.Second
            };
        }

    }
}