using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumOfEvensArray32
{
    public class Program
    {
        public static int AddEvens(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                if (temp % 2 == 0)
                {
                    sum += temp;
                }
            }
            return (sum);
        }
        public static void Main(string[] args)
        {
            int ans;
            int[] array = { 1, 1, 3, 5, 8, 13, 14, 12, 5, 3, 118 };
            ans = AddEvens(array);
            Console.WriteLine(string.Format("the sum is: {0}", ans));
            Console.ReadLine();
        }
    }
}
