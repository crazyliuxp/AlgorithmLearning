using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmLearning
{
    public class Leetcode_RepeatedSubstringPattern
    {
        public bool RepeatedSubstringPattern(string s)
        {
            //假设 s字符串由子串x重复n次得出,即s=nx
            //则 s+s=2nx
            //移除s+s头和尾的一个字符,则(s + s).Substring(1, (s + s).Length - 2),则破坏了开头和结尾的两个子串
            //此时的字符串中只有2n-2个子串
            //若s在(s + s).Substring(1, (s + s).Length - 2)中,则有2n-2>=n 即n>=2
            //即s至少由x重复2次构成
            //否则，n < 2，n 为整数，只能取 1，说明 s 不能由其子串重复多次构成
            return (s + s).Substring(1, (s + s).Length - 2).Contains(s);
        }

        public bool RepeatedSubstringPattern1(string s)
        {
            if(string.IsNullOrEmpty(s)) return false;

            for (int i = 2; i < s.Length; i++)
            {
                StringBuilder builder = new StringBuilder();
                for (int j = 0; j < i;j++){
                    builder.Append(s.Substring(0, s.Length / i));
                }
                if(builder.ToString().Equals(s)){
                    return true;
                }
            }

            return false;
        }
    }
}