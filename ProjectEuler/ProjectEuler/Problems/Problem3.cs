using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem3 : Solve
    {
        public override object Operate()
        {
            List<int> NoList = new List<int>();

            NoList.Add(2);
            NoList.Add(3);

            bool primeNoFlag = false;

            for (int i = 4; i < 10000; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primeNoFlag = false;

                        break;
                    }
                }

                if (primeNoFlag)
                {
                    NoList.Add(i);
                }

                primeNoFlag = true;
            }

            NoList.Reverse();

            foreach (int item in NoList)
            {
                if (600851475143 % item == 0)
                {
                    Console.WriteLine(item);
                }
            }

            return 0;
        }
    }
    }
}
