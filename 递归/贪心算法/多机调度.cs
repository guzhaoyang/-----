/*****************************
 * 
 * https://www.cnblogs.com/cy0628/p/13965708.html
 * 
 * ***************************/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace 贪心算法
{
    public class 多机调度
    {
        public const int N = 7;//作业数
        public const int M = 3;//机器数 
        int[] s = new int[M] { 0, 0, 0 };//每台机器当前已分配的作业总耗时 

        //求出目前处理作业的时间和 最小的机器号
        public int min(int m)
        {
            int min = 0;
            int i;
            for (i = 1; i < m; i++)
            {
                if (s[min] > s[i])
                {
                    min = i;
                }
            }
            return min;
        }

        //求最终结果（最长处理时间）
        public int max(int[] s, int num)
        {
            int max = s[0];
            int i;
            for (i = 1; i < num; i++)
            {
                if (max < s[i])
                {
                    max = s[i];
                }
            }
            return max;
        }

        //机器数大于待分配作业数
        public int setwork1(int[] t, int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                s[i] = t[i];
            }
            int ma = max(s, N);
            return ma;
        }

        //机器数小于待分配作业数 
        public int setwork2(int[] t, int n)
        {
            int i;
            int mi = 0;
            for (i = 0; i < n; i++)
            {
                mi = min(M);
                Console.WriteLine($"第{i}号作业,时间和最小的机器号为{mi}.时间和为{s[mi]}：");
                s[mi] = s[mi] + t[i];

            }
            int ma = max(s, M);
            return ma;
        }
    }
}
