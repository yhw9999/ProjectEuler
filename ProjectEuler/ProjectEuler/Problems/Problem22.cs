using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem22 : Solve
    {
        public override object Operate()
        {
            BigInteger result = new BigInteger();

            StringBuilder sb = new StringBuilder();

            sb.Append(File.ReadAllText(@"..\..\names.txt", Encoding.Default).ToString());

            string readResult = sb.ToString();

            while (readResult.IndexOf('"') != -1)
            {
                int index = readResult.IndexOf('"');

                readResult = readResult.Remove(index, 1);
            }

            string[] names = readResult.Split(',');

            Array.Sort<string>(names);

            for (int i = 0; i < names.Length; i++)
            {
                result += GetValue(names[i]) * (i + 1);
            }

            Console.WriteLine(result);

            return result;
        }

        private static int GetValue(string name)
        {
            int result = 0;

            char[] nameToArray = name.ToArray();

            for (int i = 0; i < nameToArray.Length; i++)
            {
                result += ((int)nameToArray[i] - 0x40);
            }

            return result;
        }
    }
}
