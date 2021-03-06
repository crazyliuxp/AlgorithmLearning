﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLearning.表示数字的字符串
{
    public class NumberStr
    {
        public bool IsNumber(string s)
        {
            if (s == null || s.Length == 0) return false; // s为空对象或 s长度为0(空字符串)时, 不能表示数值
            bool isNum = false, isDot = false, ise_or_E = false; // 标记是否遇到数位、小数点、‘e’或'E'
            char[] str = s.Trim().ToCharArray();  // 删除字符串头尾的空格，转为字符数组，方便遍历判断每个字符
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9') isNum = true; // 判断当前字符是否为 0~9 的数位
                else if (str[i] == '.')
                { // 遇到小数点
                    if (isDot || ise_or_E) return false; // 小数点之前可以没有整数，但是不能重复出现小数点、或出现‘e’、'E'
                    isDot = true; // 标记已经遇到小数点
                }
                else if (str[i] == 'e' || str[i] == 'E')
                { // 遇到‘e’或'E'
                    if (!isNum || ise_or_E) return false; // ‘e’或'E'前面必须有整数，且前面不能重复出现‘e’或'E'
                    ise_or_E = true; // 标记已经遇到‘e’或'E'
                    isNum = false; // 重置isNum，因为‘e’或'E'之后也必须接上整数，防止出现 123e或者123e+的非法情况
                }
                else if (str[i] == '-' || str[i] == '+')
                {
                    if (i != 0 && str[i - 1] != 'e' && str[i - 1] != 'E') return false; // 正负号只可能出现在第一个位置，或者出现在‘e’或'E'的后面一个位置
                }
                else return false; // 其它情况均为不合法字符
            }
            return isNum;
        }
    }
}
