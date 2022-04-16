using System;
using System.Linq;

namespace ProgramSum
{
    public class Program
    {
        /// <summary>
        /// this is the principal method, which takes two numbers stored one digit at a time in an array
        /// NOTE: I have another method that I did that do the additions doing modules and divisions but 
        /// I consider this simplest, so, I only uploaded this method
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static ulong Sum(uint[] array1, uint[] array2)
        {
            try
            {
                //convert the first array in a number
                ulong number1 = ConvertArrayToLong(array1);
                //reverse the second array
                uint[] array3 = Enumerable.Reverse(array2).ToArray();
                //convert the second array (reversed) in a number
                ulong number2 = ConvertArrayToLong(array3);
                //calculate the sum
                return number1 + number2;
            }
            catch 
            { throw; }
        }

        /// <summary>
        /// I used uint to not allow negative values
        /// </summary>
        /// <param name="array1"></param>
        /// <returns></returns>
        static ulong ConvertArrayToLong(uint[] array1)
        {

            ulong number = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] >= 10)
                    throw new ArgumentException("at least one element of the array has more than one digit");
                
                number += array1[i] * Convert.ToUInt64(Math.Pow(10, array1.Length - i - 1));
            }
            return number;

        }

        static void Main(string[] args)
        {
            uint[] array1 = { 7, 8, 9 };
            uint[] array2 = { 4, 2 };
            ulong resulteasy = Sum(array1, array2);
            Console.WriteLine("array1 :" + string.Join("", array1));
            Console.WriteLine("array2 :" + string.Join("", array2));
            Console.WriteLine("result: " + resulteasy);
            Console.ReadLine();
        }
    }
}
