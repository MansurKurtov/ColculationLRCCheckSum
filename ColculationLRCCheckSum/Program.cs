namespace ColculationLRCCheckSum
{
    /// <summary>
    /// Colculation LRC check sum
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var data = new byte[] { 0x30, 0x30, 0x34, 0x35, 0x34, 0x30, 0x34, 0x03 };
            var result = data.GetLRC(); // 0x33, 0x32
        }
    }
}
