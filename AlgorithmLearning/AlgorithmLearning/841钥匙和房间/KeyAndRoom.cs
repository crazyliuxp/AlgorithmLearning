using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLearning._841钥匙和房间
{
    /// <summary>
    /// 841. 钥匙和房间
    /// https://leetcode-cn.com/problems/keys-and-rooms/
    /// </summary>
    public class KeyAndRoom
    {
        private bool[] vis;
        private int num;
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            int len = rooms.Count;
            vis = new bool[len];
            num = 0;

            //从第0个房间开始
            dfs(rooms, 0);

            return num == len;
        }

        private void dfs(IList<IList<int>> rooms, int index)
        {
            vis[index] = true;
            num++;
            
            foreach(var roomNum in rooms[index]){
                if (!vis[roomNum])
                {
                    dfs(rooms, roomNum);
                }
            }
        }
    }
}
