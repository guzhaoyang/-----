/*********************************************
 * 
 * https://www.cnblogs.com/wkfvawl/p/11766662.html
 * https://www.cnblogs.com/xing901022/archive/2012/10/23/2735058.html
 * 
 * *******************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 回溯法
{
    public class 符号三角形问题
    {
        public static int n, half, count;// 第一行的符号个数n，当前“+”个数count，
        public static int[,] p;// 符号三角形矩阵
        public static long sum;// 符合条件的符号三角形个数

        public static long computs(int nn)
        {
            n = nn;
            count = 0;
            sum = 0;
            half = n * (n + 1) / 2;
            if (half % 2 == 1)// 无解的判断：n*(n+1)/2为奇数
            {
                return 0;
            }
            half = half / 2;

            p = new int[n + 1,n + 1];
            for (int i = 0; i < n; i++)// 数组初值
            {
                for (int j = 0; j < n; j++)
                {
                    p[i,j] = 0;
                }
            }
            backtrack(1);
            return sum;
        }

        public static void backtrack(int t)
        {
            if ((count > half) || (t * (t - 1) / 2 - count > half))
                return;// 若符号统计未超过半数，并且另一种符号也未超过半数
            if (t > n)
            {
                sum++;
            } // 当i>n时，算法搜索至叶节点，得到一个新的“+”个数与“—”个数相同的符号三角形，当前已找到的符号三角形数sum增1.
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    p[1,t] = i;
                    count += i;
                    for (int j = 2; j <= t; j++)
                    {
                        if (p[j - 1,t - j + 1] == p[j - 1,t - j + 2])
                        {
                            p[j,t - j + 1] = 1;
                            // 2个同号下面都是“+”
                        }
                        else
                        {
                            p[j,t - j + 1] = 0;
                            // 2个异号下面都是“-”
                        }
                        count += p[j,t - j + 1];
                    }
                    backtrack(t + 1);
                    for (int j = 2; j <= t; j++)
                    {
                        // 回溯时取消上一次的赋值
                        count -= p[j,t - j + 1];
                    }
                    count -= i;
                }
            }
        }
    }
}
