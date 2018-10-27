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

            int[] array = { 3, 8, 9, 7, 6,3,6,7,5,6,7,45,34,6,23,-46 };
           var rotatearray = CyclicRotation.solution(array, 3);
            foreach (var item in rotatearray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
