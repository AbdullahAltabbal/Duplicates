using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DuplicateCount("aabBcde"));

        }

        public static int DuplicateCount(string str)
        {
            var neuString = str.ToLower().ToArray();

            Dictionary<char, int> charDic = new Dictionary<char, int>();

            foreach (var item in neuString)
            {
                if (charDic.ContainsKey(item))
                {
                    charDic[item] = charDic[item] + 1;
                }
                else charDic.Add(item,1);
            }

            int cou = 0;
            foreach (var item in charDic)
            {
                if (item.Value > 1)
                {
                    cou++;
                }
            }
            return cou;
        }
    }
}
