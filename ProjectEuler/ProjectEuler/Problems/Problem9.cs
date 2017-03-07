using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem9 : Solve
    {
        public override object Operate()
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    for (int k = 0; k < 1000; k++)
                    {
                        int a = i * i;
                        int b = j * j;
                        int c = k * k;

                        if (a + b == c && i + j + k == 1000)
                        {
                            Console.WriteLine($"{i}, {j}, {k}");

                            Console.WriteLine($"{i * j * k}");
                        }
                    }
                }
            }

            return 0;
        }
    }
}
