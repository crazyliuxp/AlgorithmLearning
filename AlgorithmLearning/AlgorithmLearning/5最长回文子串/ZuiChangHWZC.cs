using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLearning._5最长回文子串
{
    /// <summary>
    /// 最长回文子串
    /// </summary>
    public class ZuiChangHWZC
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "";

            int maxLen = 0;
            int startIndex = 0;

            //abav
            for(int i = 0; i < s.Length; i++)
            {
                int left = i - 1;
                int right = i + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    int itemMax = right - left;
                    if (itemMax > maxLen)
                    {
                        maxLen = itemMax;
                        startIndex = left;
                    }
                    left--;
                    right++;
                }

                left = i;
                right = i + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    int itemMax = right - left;
                    if (itemMax > maxLen)
                    {
                        maxLen = itemMax;
                        startIndex = left;
                    }
                    left--;
                    right++;
                }
            }

            return maxLen == 0 ? s[0].ToString() : s.Substring(startIndex, maxLen + 1);
        }
    }
}
