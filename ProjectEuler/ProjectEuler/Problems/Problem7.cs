using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem7 : Solve
    {
        public override object Operate()
        {
            int count = 0;

            int checkNo = 2;

            bool primeFlag = true;

            while (count < 10002)
            {
                for (int i = 2; i <= checkNo; i++)
                {
                    if (checkNo % i == 0 && i < checkNo)
                    {
                        primeFlag = false;

                        break;
                    }
                }

                if (primeFlag)
                {
                    count++;

                    if (count == 10001)
                    {
                        Console.WriteLine(checkNo);
                    }
                }

                primeFlag = true;

                checkNo++;
            }

            return 0;
        }
    }
}
