/**************************************
 * 
 * https://blog.csdn.net/m0_38015368/article/details/80196634
 * 
 * ************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 回溯法
{
    public class 装载问题
    {
        int n; //集装箱数
        int cw; // 当前载重量, current weight
        int bestw; //最优载重重量
        int r;  //剩余集装箱重量
        int c1; //第一艘轮船的载重量
        int c2; //第二艘轮船的载重量
        int[] x = new int[100]; //当前解
        int[] bestx = new int[100]; //当前最优解
        int[] w = new int[100]; //集装箱重量数组

        public void OutPut()
        {
            int restweight = 0;
            for (int i = 1; i <= n; ++i)
                if (bestx[i] == 0)
                    restweight += w[i];
            if (restweight > c2)
                Console.WriteLine("不能装入");
            else
            {
                Console.Write("船1装入的货物为:");
                for (int i = 1; i <= n; ++i)
                    if (bestx[i] == 1)
                        Console.Write($" {i}");
                Console.WriteLine();

                Console.Write("船2装入的货物为:");
                for (int i = 1; i <= n; ++i)
                    if (bestx[i] != 1)
                        Console.Write($" {i}");
                Console.WriteLine();
            }
        }
        public void BackTrack(int i)
        {
            if (i > n)
            {
                if (cw > bestw)
                {
                    for (i = 1; i <= n; ++i)
                        bestx[i] = x[i];
                    bestw = cw;
                }
                return;
            }
            r -= w[i];
            if (cw + w[i] <= c1) //约束条件
            {
                cw += w[i];
                x[i] = 1;
                BackTrack(i + 1);
                x[i] = 0;
                cw -= w[i];
            }
            if (cw + r > bestw) //限界函数
            {
                x[i] = 0;
                BackTrack(i + 1);
            }
            r += w[i];

        }
        public void Initialize()
        {
            bestw = 0;
            r = 0;
            cw = 0;
            for (int i = 1; i <= n; ++i)
                r += w[i];
        }
        public void InPut()
        {
            this.n = 3;
            this.c1 = 50;
            this.c2 = 50;
            w[1] = 10;
            w[2] = 40;
            w[3] = 40;            
        }
    }
}
