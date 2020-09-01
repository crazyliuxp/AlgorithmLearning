using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmLearning._557反转字符串中的字符
{
    public class FanZhuan
    {
        public string ReverseWords(string s)
        {
            var arr = s.Split(' ');

            List<string> result = new List<string>();
            foreach(var str in arr)
            {
                result.Add(string.Join("", str.Reverse().ToArray()));
            }

            return string.Join(" ", result);
        }
    }
}
