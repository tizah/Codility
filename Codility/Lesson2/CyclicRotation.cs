﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CyclicRotation
    {
        /// <summary>
        /// For example, given

        //  A = [3, 8, 9, 7, 6]
        //  K = 3
        //the function should return [9, 7, 6, 3, 8]. Three rotations were made:

        //  [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
        //  [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
        //  [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
        /// </summary>
        /// <param name="array"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] RotateArrayKtimes(int[] array, int k)
        {
            int[] array2 = new int[array.Length];
            int numberOfElement = array.Length;
            if (array.Length > 0 || k == 0)
            {
                var lastElement = array[numberOfElement - 1];

                // lastElement = array2[numberOfElement - 1];
                array2[0] = lastElement;
                for (int i = 1; i < array.Length; i++)
                {
                    array2[i] = array[i - 1];
                }
                k--;
                if (k >= 1)
                {
                    array2 = RotateArrayKtimes(array2, k);
                }

            }

            return array2;
        }

        public static int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var numberOfElements = A.Length;

            if (K == 0 || numberOfElements == 0)
            {

                return A;
            }

            int[] array2 = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                if (i < (K % numberOfElements))
                {
                    array2[i] = A[(numberOfElements - (K % numberOfElements)) + i];
                }
                else
                {
                    array2[i] = A[System.Math.Abs((K % numberOfElements) - i)];
                }

            }
            return array2;
        }
    }
}
