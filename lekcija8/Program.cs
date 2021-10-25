using System;
using System.Collections.Generic;

namespace lekcija8
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskHas12();
            TaskModThree();
        }
      
        static void TaskModThree()
        {
            var list = new List<int> { 5,4, 6, 1, 2, 4 };
            var countOdd = 0;
            var countEven = 0;
            foreach (var i in list)
            {
                var isEven = i % 2 == 0;
                if (isEven) countEven++;
                else countOdd++;
            }
            Console.WriteLine(countOdd == 3 || countEven == 3);
        }
        static void TaskHas12()
        {
            var list = new List<int> {5, 2, 1, 2, 4 };
            var hasOne = false;
            var hasTwo = false;
            foreach (var i in list)
            {
                if (hasOne)
                {
                    if (i == 2) hasTwo = true;
                }
                else
                {
                    if (i == 1) hasOne = true;
                }
            }
            Console.WriteLine(hasOne && hasTwo);
        }
    }
}
