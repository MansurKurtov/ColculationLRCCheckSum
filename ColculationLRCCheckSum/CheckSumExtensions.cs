using System;

namespace ColculationLRCCheckSum
{
    internal static class CheckSumExtensions
    {
        internal static byte[] GetLRC(this byte[] nums)
        {

            byte current = 0x00;
            foreach (var value in nums)
            {
                current ^= value;
            }

            return current.ByteToLRCByteArray();
        }
        private static byte[] ByteToLRCByteArray(this byte data)
        {
            var resultData = new byte[2];
            var byteString = BitConverter.ToString(new byte[] { data });

            for (int i = 0; i < byteString.Length; i++)
                resultData[i] = Convert.ToByte(byteString[i]);

            return resultData;
        }
    }
}
