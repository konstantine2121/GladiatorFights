using GladiatorFights.Dto;
using System.Collections.Generic;

namespace GladiatorFights.Interfaces.Fighters
{
    public interface IInfoProvider
    {
        IReadOnlyList<ColoredText> GetInfo();
    }
}
