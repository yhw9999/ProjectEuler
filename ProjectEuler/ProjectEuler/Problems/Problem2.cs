using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem2 : Solve
    {
        public override object Operate()
        {
            List<int> NoList = new List<int>();

            int total = 0;

            int frontNo = 1;

            int backNo = 2;

            NoList.Add(frontNo);
            NoList.Add(backNo);

            while (true)
            {
                int addResult = frontNo + backNo;

                if (addResult <= 4000000)
                {
                    NoList.Add(addResult);

                    frontNo = backNo;

                    backNo = addResult;
                }
                else
                {
                    break;
                }
            }

            foreach (int item in NoList)
            {
                if (item % 2 == 0)
                {
                    total += item;
                }
            }

            return total;
        }
    }
}
