/**************************
 * 
 * https://blog.csdn.net/qq_44766883/article/details/106992785
 * 
 * ***********************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 分支限界法
{
    public class 旅行售货员问题
    {
        public const int NO_PATH = -1;        //没有通路
        public const int MAX_WEIGHT = 4000;

        public int N;                     //城市数目
        public int[,] City_Graph = new int[100,100];  //保存图信息
        public int[] x = new int[100];                //x[i]保存第i步遍历的城市
        public int[] isIn = new int[100];             //保存 城市i是否已经加入路径
        public int bestw;                 //最优路径总权值
        public int cw;                    //当前路径总权值
        public int[] bestx = new int[100];            //最优路径

        public void Travel_Backtrack(int t)
        {        //递归法
            int i, j;
            if (t > N)
            {                         //走完了，输出结果
                for (i = 1; i <= N; i++)            //输出当前的路径
                    Console.Write(x[i]);
                Console.WriteLine();
                if (cw < bestw)
                {              //判断当前路径是否是更优解
                    for (i = 1; i <= N; i++)
                    {
                        bestx[i] = x[i];
                    }
                    bestw = cw + City_Graph[x[N],1];
                }
                return;
            }
            else
            {
                for (j = 1; j <= N; j++)
                {           //找到第t步能走的城市
                    if (City_Graph[x[t - 1],j] != NO_PATH && isIn[j] == 0)
                    { //能到而且没有加入到路径中
                        isIn[j] = 1;
                        x[t] = j;
                        cw += City_Graph[x[t - 1],j];
                        Travel_Backtrack(t + 1);
                        isIn[j] = 0;
                        x[t] = 0;
                        cw -= City_Graph[x[t - 1],j];
                    }
                }
            }
        }
    }
}
