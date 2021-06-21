using System;

namespace Cyclic_number
{
    class Program
    {
        public static string SortString(string inputString)
        {
            char[] tempArray = inputString.ToCharArray();
            Array.Sort(tempArray);
            return new string(tempArray);
        }

        public static bool SameDigit(int num1, int num2)
        {
            string str1 = num1.ToString();
            string str2 = num2.ToString();
            if (SortString(str1) == SortString(str2))
                return true;

            return false;
        }

        public static bool SameDigitArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!SameDigit(arr[0], arr[i]))
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            for (int num = 100000; num < (int)Math.Pow(10, 6) / 6; num++)
            {
                int[] nums = { num, num * 2, num * 3, num * 4, num * 5, num * 6 };

                if (SameDigitArr(nums))
                    Console.WriteLine("This number is :" + num);
            }

            watch.Stop();
            Console.WriteLine($"Execution time {watch.ElapsedMilliseconds} ms");

        }
    }
}
