using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLearning._657机器人能否返回原点
{
    /// <summary>
    /// 机器人能够返回原点
    /// </summary>
    public class JiQiRen
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            foreach(char move in moves)
            {
                switch (move)
                {
                    case 'U':
                        y--;
                        break;
                    case 'D':
                        y++;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'R':
                        x++;
                        break;
                }
            }

            return x == 0 && y == 0;
        }
    }
}
