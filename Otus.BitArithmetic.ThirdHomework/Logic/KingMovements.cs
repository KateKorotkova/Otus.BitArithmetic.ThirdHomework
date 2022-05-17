namespace Otus.BitArithmetic.ThirdHomework.Logic
{
    public class KingMovements
    {
        public ulong GetMoves(int position)
        {
            var kingBit = 1ul << position;
            var maskWithoutLeftBorder = 0xfefefefefefefefe;
            ulong maskWithoutRightBorder = 0x7f7f7f7f7f7f7f7f;
            var kingWithoutLeftBorder = kingBit & maskWithoutLeftBorder;
            var kingWithoutRightBorder = kingBit & maskWithoutRightBorder;

            return (kingWithoutLeftBorder << 7) | (kingBit << 8) | (kingWithoutRightBorder << 9) |
                   (kingWithoutLeftBorder >> 1) |                  (kingWithoutRightBorder << 1) |
                   (kingWithoutLeftBorder >> 9) | (kingBit >> 8) | (kingWithoutRightBorder >> 7);
        }
    }
}
