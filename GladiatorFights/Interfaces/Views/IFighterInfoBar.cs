using GladiatorFights.Interfaces.Fighters;

namespace GladiatorFights.Interfaces.Views
{
    interface IFighterInfoBar
    {
        void Bind(IFighter fighter);
        void Update();
    }
}
