using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem1 : Solve
    {
        public override object Operate()
        {
            int total = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    total += i;
                }
                else if (i % 5 == 0)
                {
                    total += i;
                }
            }

            return total;
        }
    }
}
