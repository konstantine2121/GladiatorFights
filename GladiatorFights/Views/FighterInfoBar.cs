using GladiatorFights.Interfaces.Fighters;
using GladiatorFights.Interfaces.Views;

namespace GladiatorFights.Views
{
    class FighterInfoBar : ConsoleTable, IFighterInfoBar
    {
        private IInfoProvider _fighter;

        public FighterInfoBar(int positionLeft, int positionTop)
            : base(positionLeft, positionTop)
        {

        }

        public override void Update()
        {
            if (_fighter != null)
            {
                SetNewInfo(_fighter.GetInfo());
            }

            base.Update();
        }

        public void Bind(IInfoProvider fighter)
        {
            _fighter = fighter;
        }
    }
}
