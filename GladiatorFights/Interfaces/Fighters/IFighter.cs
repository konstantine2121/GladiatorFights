using System;
using System.Collections.Generic;
using GladiatorFights.Dto;

namespace GladiatorFights.Interfaces.Fighters
{
    public interface IFighter : IInfoProvider
    {
        event Action<IFighter> Died;

        string Name { get; }

        string Class { get; }

        int Health { get; }

        bool Dead { get; }

        int Damage { get; }

        int DealDamage();

        int TakeDamage(int incomingDamage);

        void Regenerate();

        void ResetStats();
    }
}
