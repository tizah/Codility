using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = 529;
            //var binaryGap = BinaryGap.CountHighestBinaryGap(number);
            //Console.WriteLine(binaryGap);

            int[] array = { 3, 8, 9, 7, 6 };
            var rotatearray = CyclicRotation.RotateArrayKtimes(array, 2);
            foreach (var item in rotatearray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
