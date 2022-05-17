namespace Otus.BitArithmetic.ThirdHomework.Logic
{
    public class HorseMovements
    {
        public int GetMovesCount(int position)
        {
            var knightBits = 1ul << position;
            ulong maskWithoutOneLeftBorder = 0xFeFeFeFeFeFeFeFe;
            ulong maskWithoutTwoLeftBorder = 0xFcFcFcFcFcFcFcFc;
            ulong maskWithoutOneRightBorder = 0x7f7f7f7f7f7f7f7f;
            ulong maskWithoutTwoRightBorder = 0x3f3f3f3f3f3f3f3f;

            var horseMask = maskWithoutTwoRightBorder & (knightBits << 6 | knightBits >> 10)
                                | maskWithoutOneRightBorder & (knightBits << 15 | knightBits >> 17)
                                | maskWithoutOneLeftBorder & (knightBits << 17 | knightBits >> 15)
                                | maskWithoutTwoLeftBorder & (knightBits << 10 | knightBits >> 6);

            return PopCnt.CalculateViaCache(horseMask);
        }
    }
}
