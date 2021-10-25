using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Program2
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            return flower1 % 2 != flower2 % 2;
        }
    }

    class Program3
    {
        public static bool Check(object[] a, object x)
        {
            foreach (var i in a)
            {
                Console.WriteLine(x);
                if (i.Equals(x))
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program4
    {
        public static int PositiveSum(int[] arr)
        {
            var sumNum = 0;
            foreach (var i in arr)
            {
                if (i > 0)
                {
                    sumNum += i;
                }
            }
            if (sumNum > 0)
            {
                return sumNum;
            }
            else
            {
                return 0;
            }

        }
    }


}

