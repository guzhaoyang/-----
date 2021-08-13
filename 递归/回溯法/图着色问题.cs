/*****************************
 * 
 * https://blog.csdn.net/jeffleo/article/details/54586046
 * 
 * ***************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 回溯法
{
    public class 图着色问题
    {
        public int v, e;//v顶点数， e边数
        public int[,] graph = new int[100,100];//graph图的邻接矩阵 
        public int c;//c颜色数
        public int[] color = new int[100];//color当前边的颜色 
        public int sum = 0;//着色方法的数目 

        //判断当前位置的颜色是否和相邻位置颜色重复 
        public bool ok(int cur)
        {
            for (int i = 1; i <= v; i++)
            {
                if (graph[cur,i] == 1 && color[cur] == color[i])
                {
                    //如果坐标(cur,i)相邻 且 cur的颜色和i的颜色相同 
                    return false;
                }
            }
            return true;
        }

        public void backtrace(int cur)
        {
            if (cur > v)
            {
                sum++;
            }
            else
            {
                for (int i = 1; i <= c; i++)
                {//分别为cur位置尝试第i中颜色 
                    color[cur] = i;//表示cur位置图上第i种颜色 
                    if (ok(cur))
                    {
                        backtrace(cur + 1);
                    }
                    color[cur] = 0;
                }
            }
        }
    }
}
