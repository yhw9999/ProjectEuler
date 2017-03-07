using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem25 : Solve
    {
        double front = 1.0;
        double back = 1.0;

        BigInteger totalCount = 2;
        BigInteger count = 1;

        public override object Operate()
        {
            while (true)
            {
                totalCount++;

                if (totalCount % 2 == 1)
                {
                    front += back;

                    if (front > 10)
                    {
                        front /= 10;
                        back /= 10;

                        count++;
                    }
                }
                else
                {
                    back += front;

                    if (back>10)
                    {
                        front /= 10;
                        back /= 10;

                        count++;

                    }
                }

                if (count == 1000)
                {
                    break;
                }
            }

            Console.WriteLine(totalCount);

            return totalCount;
        }
    }
}
