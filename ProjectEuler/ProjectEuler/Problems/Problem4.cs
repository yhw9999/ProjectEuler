using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem4 : Solve
    {
        public override object Operate()
        {
            List<string> ableList = new List<string>();

            int maxValue = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    string reverseTarget = (i * j).ToString();

                    char[] reverseArray = reverseTarget.ToCharArray();

                    Array.Reverse(reverseArray);
                    string reverseResult = new string(reverseArray);

                    if (reverseTarget == reverseResult)
                    {
                        ableList.Add((i * j).ToString());
                    }
                }
            }

            foreach (var item in ableList)
            {
                if (maxValue < int.Parse(item))
                {
                    maxValue = int.Parse(item);
                }

            }

            Console.WriteLine(maxValue);

            return 0;
        }
    }
}
