using System;
using Otus.BitArithmetic.ThirdHomework.Logic;

namespace Otus.BitArithmetic.ThirdHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var kingMovements = new KingMovements();
            Console.WriteLine($"King movements for 15: {kingMovements.GetMoves(15)}");
            Console.WriteLine($"King movements for 0: {kingMovements.GetMoves(0)}");

            var horseMovements = new HorseMovements();
            Console.WriteLine($"Horse movements count for 27: {horseMovements.GetMovesCount(27)}");

            Console.ReadKey();
        }
    }
}
