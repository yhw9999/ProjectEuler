using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem5 : Solve
    {
        public override object Operate()
        {
            int count = 1;

            bool breakFlag = false;

            while (true)
            {
                int i;

                for (i = 1; i <= 20; i++)
                {
                    if (!(count % i == 0))
                    {
                        breakFlag = false;

                        break;
                    }
                }

                if (breakFlag)
                {
                    Console.WriteLine(count);
                }

                breakFlag = true;

                count++;
            }
        }
    }
}
