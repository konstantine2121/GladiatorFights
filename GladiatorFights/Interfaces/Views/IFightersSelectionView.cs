using System.Collections.Generic;

namespace GladiatorFights.Interfaces.Views
{
    interface IFightersSelectionView
    {
        IReadOnlyList <IFighterInfoBar> FighterInfoBarList { get; }

        void Update();
    }
}
