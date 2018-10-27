using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class BinaryGap
    {
        public static int CountHighestBinaryGap(int number)
        {
            var binary = Convert.ToString(number, 2);
            int binaryGap = 0;
            int longestGap = 0;

            for (int i = 0; i < binary.Length - 1; i++)
            {
                if (binary[i] == '1' && binary[i + 1] == '0')
                {
                    binaryGap = 1;
                }
                else if (binary[i] == '0' && binary[i + 1] == '0')
                {
                    binaryGap++;
                }
               else if (binary[i] == '0' && binary[i + 1] == '1')
                {
                    longestGap = Math.Max(longestGap,binaryGap);
                }
            }
            return longestGap;
        }
    }
}
