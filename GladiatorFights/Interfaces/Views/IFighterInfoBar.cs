using GladiatorFights.Interfaces.Fighters;

namespace GladiatorFights.Interfaces.Views
{
    interface IFighterInfoBar
    {
        void Bind(IInfoProvider fighter);
        void Update();
    }
}
