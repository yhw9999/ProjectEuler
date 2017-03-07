using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem6 : Solve
    {
        public override object Operate()
        {
            int addResult = 0;
            int multiResult = 0;
            int totalResult = 0;

            for (int i = 1; i <= 100; i++)
            {
                addResult += i;

                multiResult += i * i;
            }

            addResult = addResult * addResult;

            totalResult = addResult - multiResult;

            Console.WriteLine(totalResult);

            return totalResult;
        }
    }
}
