using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem26 : Solve
    {
        List<string> remainList = new List<string>();

        Dictionary<int, string> tmpDic = new Dictionary<int, string>();

        int LargestLength;

        string loop;

        int number;

        int remainCount;

        public override object Operate()
        {
            for (double i = 1; i < 1001 ; i++)
            {
                if (i % 2 != 0 && i % 5 != 0)
                {
                    Divide(1, i);
                }
                else
                {
                    remainList.Add(null);
                }
            }

            foreach (var item in remainList)
            {
                if (item != null)
                {
                    CheckLoopNode(item);
                }


                remainCount++;
            }

            return 0;
        }

        private void CheckLoopNode(string node)
        {
            int offset = 0;

            int size = 1;

            int count = 0;

            while (true)
            {
                if (count == node.Length)
                {
                    offset++;
                }

                count++;

                string tmpString1 = GetString(node, offset, size);
                string tmpString2 = GetString(node, (offset+size), size);

                size++;

                if (tmpString1 == tmpString2)
                {
                    if (LargestLength < tmpString1.Length)
                    {
                        LargestLength = tmpString1.Length;

                        number = remainCount;

                        loop = tmpString1;

                        tmpDic.Add(remainCount, node);

                        break;
                    }
                }
            }
        }

        private string GetString(string node, int offset, int size)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = offset; i < offset+size; i++)
            {
                sb.Append(node[i]);
            }

            return sb.ToString();
        }

        private double Divide(int one, double number)
        {
            int count = 0;
            int remainNumber = 1;
            int dividedNumber = 1;

            StringBuilder sb = new StringBuilder();

            while (count < 1000)
            {
                double a = one / number;

                string[] stringArray = a.ToString().Split('.');

                if (stringArray.Length > 1)
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        dividedNumber = (int)(remainNumber * 10 / number);
                        remainNumber = (int)(remainNumber * 10 % number);

                        sb.Append(dividedNumber);
                    }

                    remainList.Add(sb.ToString());

                    break;
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }
    }
}
