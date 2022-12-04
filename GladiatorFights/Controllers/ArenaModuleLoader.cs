using System;
using System.Collections.Generic;
using GladiatorFights.Enums;
using GladiatorFights.BusinessObjects.Fighters;
using GladiatorFights.Interfaces.Fighters;

namespace GladiatorFights.Controllers
{
    class ArenaModuleLoader
    {
        public IFighter Fighter1 { get; private set; }

        public IFighter Fighter2 { get; private set; }


        public Dictionary<FighterType, IFighter> CreateExampleFigters()
        {
            const string name = "Пример";

            var result = new Dictionary<FighterType, IFighter>()
            {
                {FighterType.Warrior, new Warrior(name) },
                {FighterType.Healer, new Healer(name) },
                {FighterType.Berserk, new Berserk(name) },
                {FighterType.Thief, new Thief(name) },
                {FighterType.MagicianOfFire, new MagicianOfFire(name) },
            };

            return result;
        }

        public void CreateFigter1(string name, FighterType fighterType)
        {
            Fighter1 = CreateFigter(name, fighterType);
        }

        public void CreateFigter2(string name, FighterType fighterType)
        {
            Fighter2 = CreateFigter(name, fighterType);
        }

        private IFighter CreateFigter(string name, FighterType fighterType)
        {
            IFighter result = null;

            switch(fighterType)
            {
                case FighterType.Warrior:
                    result = new Warrior(name);
                    break;

                case FighterType.Healer:
                    result = new Healer(name);
                    break;

                case FighterType.Berserk:
                    result = new Berserk(name);
                    break;

                case FighterType.Thief:
                    result = new Thief(name);
                    break;

                case FighterType.MagicianOfFire:
                    result = new MagicianOfFire(name);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(fighterType));
            }

            return result;
        }
    }
}
