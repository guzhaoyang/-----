using System;

namespace 分支限界法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region 旅行售货员问题

            旅行售货员问题 旅行售货员问题 = new 旅行售货员问题();
            旅行售货员问题.N = 4;
            旅行售货员问题.City_Graph = new int[,] {
                { 0,0,0,0,0},
                { 0,-1 ,30 ,6 ,4 },
                { 0,30, -1, 5, 10 },
                { 0,6, 5, -1, 20 },
                { 0,4, 10, 20, -1 }
            };
            int i = 0;
            Console.WriteLine($"请输入城市数目:{旅行售货员问题.N}");
            for (i = 1; i <= 旅行售货员问题.N; i++)
            {
                Console.WriteLine($"请输入第{ i }座城市的路程信息(不通请输入-1):");
                for (int j = 1; j <= 旅行售货员问题.N; j++)
                {
                    Console.WriteLine(旅行售货员问题.City_Graph[i,j]);
                }
            }

            //测试递归法
            for (i = 1; i <= 旅行售货员问题.N; i++)
            {
                旅行售货员问题.x[i] = 0;               //表示第i步还没有解
                旅行售货员问题.bestx[i] = 0;           //还没有最优解
                旅行售货员问题.isIn[i] = 0;            //表示第i个城市还没有加入到路径中
            }

            旅行售货员问题.x[1] = 1;                   //第一步 走城市1
            旅行售货员问题.isIn[1] = 1;                //第一个城市 加入路径
            旅行售货员问题.bestw = 旅行售货员问题.MAX_WEIGHT;
            旅行售货员问题.cw = 0;
            旅行售货员问题.Travel_Backtrack(2);        //从第二步开始选择城市
            Console.Write($"最优值为: {旅行售货员问题.bestw}");
            Console.Write("最优解为:");
            for (i = 1; i <= 旅行售货员问题.N; i++)
            {
                Console.Write(旅行售货员问题.bestx[i]);
            }
            Console.WriteLine();

            #endregion

            Console.ReadLine();
        }
    }
}
