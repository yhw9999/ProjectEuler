using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem21 : Solve
    {
        public override object Operate()
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            List<int> totalResult = new List<int>();

            BigInteger result = 0;

            for (int i = 1; i < 10001; i++)
            {
                List<int> divisorList = GetDivisorList(i);

                int sumDivisor = SumDivisor(divisorList);

                int checkTarget = SumDivisor(GetDivisorList(sumDivisor));

                if (i == checkTarget && i != sumDivisor)
                {
                    result += i + checkTarget;
                }

                //dic.Add(i, sumDivisor);
            }



            //foreach (int item in totalResult)
            //{
            //    result += item;
            //}

            result /= 2;

            return result;
        }

        private static int SumDivisor(List<int> divisorList)
        {
            int result = 0;

            foreach (var item in divisorList)
            {
                result += item;
            }

            return result;
        }

        private static List<int> GetDivisorList(int i)
        {
            List<int> result = new List<int>();

            for (int divisor = 1; divisor < i; divisor++)
            {
                if (i % divisor == 0)
                {
                    result.Add(divisor);
                }
            }

            return result;
        }
    }
}
