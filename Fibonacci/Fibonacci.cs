using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class Fibonachi
    {
        public static int[] fib(int num)
        {
            int[] result = new int[num];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i < num; i++)
            {
                result[i] += result[i - 1] + result[i - 2];
            }
            return result;
        }
    }
}
