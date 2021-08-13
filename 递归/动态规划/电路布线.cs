/******************************
 * 
 * 
 * https://www.cnblogs.com/Jason-Damon/p/3343602.html
 * 
 * 
 * ****************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 动态规划
{
    public class 电路布线
    {
        public static int MAX(int a, int b) 
        {
            if (a > b) return (a);
            else return (b);
        }

        public void circut(int[] a, int[,] set, int n)
        {
            int i, j;

            for (i = 0; i < n; i++)
            {
                set[i,0] = 0;
                set[0,i] = 0;
            }

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (a[i] != j)
                        set[i,j] = MAX(set[i - 1,j], set[i,j - 1]);
                    else
                        set[i,j] = set[i - 1,j - 1] + 1;
                }
            }
        }

        public void back_track(int i, int j, int[,] set)
        {
            if (i == 0)
                return;
            if (set[i,j] == set[i - 1,j])
                back_track(i - 1, j, set);
            else if (set[i,j] == set[i,j - 1])
                back_track(i, j - 1, set);
            else
            {
                back_track(i - 1, j - 1, set);
                Console.WriteLine($"({i},{j}) ", i, j);
            }
        }

    }
}
