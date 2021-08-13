/*******************************
 * 
 * https://www.cnblogs.com/Jason-Damon/p/3364985.html
 * 
 * ****************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 动态规划
{
    public class _0_1背包问题
    {
        public const int MAX_LEN = 100;
        public int MAX(int a, int b)
        {
            if ((a) > (b)) return a;
            else return b;
        }

        public int[,] value = new int[MAX_LEN, MAX_LEN];    //value[i][j]表示总重量不超过j时，前i个物品所能构成的最大价值

        int[] w = { -1, 3, 4, 5 };//物品重量数组
        int[] v = { -1, 4, 5, 6 };//物品价值数组

        public int package(int m, int n)
        {
            int i, j;

            for (j = 1; j <= n; j++)    //背包编号
            {
                for (i = 0; i <= m; i++)   //背包容量
                {
                    if (w[j] <= i)
                    {
                        value[j,i] = MAX(value[j - 1,i], v[j] + value[j - 1,i - w[j]]);
                    }
                    else
                    {
                        value[j,i] = value[j - 1,i];
                    }
                }
            }

            return value[n,m];
        }

    }
}
