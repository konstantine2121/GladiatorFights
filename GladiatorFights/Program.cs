using GladiatorFights.Creators;

namespace GladiatorFights
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new ArenaModuleCreator();
            var module = creator.Create();
            module.Run();
        }
    }
}
