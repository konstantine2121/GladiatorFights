using GladiatorFights.Creators;
using System;

namespace GladiatorFights
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 32;

            var creator = new ArenaModuleCreator();
            var module = creator.Create();
            module.Run();
        }
    }
}
