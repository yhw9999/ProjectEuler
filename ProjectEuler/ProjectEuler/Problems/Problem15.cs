using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem15 : Solve
    {
        public override object Operate()
        {
            BigInteger result = 0;

            result = GetFatorialValue(20) * GetFatorialValue(20);

            Console.WriteLine(GetFatorialValue(40) / result);

            return result;
        }

        private static BigInteger GetFatorialValue(int v)
        {
            BigInteger result = 1;
            for (int i = 1; i <= v; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
