using System;

namespace 回溯法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region 装载问题

            装载问题 装载问题 = new 装载问题();
            装载问题.InPut();
            装载问题.Initialize();
            装载问题.BackTrack(1);
            装载问题.OutPut();

            #endregion

            #region 批处理作业调度
            批处理作业调度 批处理作业调度 = new 批处理作业调度();

            批处理作业调度.number = 3;
            Console.WriteLine($"请输入作业的数量： {批处理作业调度.number}");
            int i;
            
            批处理作业调度.x1[1] = 2;
            批处理作业调度.x1[2] = 3;
            批处理作业调度.x1[3] = 2;

            Console.WriteLine("请输入每个作业在机器1的运行时间：");
            for (i = 1; i <= 批处理作业调度.number; i++)
            {
                Console.WriteLine(批处理作业调度.x1[i]);
            }
            Console.WriteLine("请输入每个作业在机器2的运行时间：");
            批处理作业调度.x2[1] = 1;
            批处理作业调度.x2[2] = 1;
            批处理作业调度.x2[3] = 3;
            for (i = 1; i <= 批处理作业调度.number; i++)
            {
                Console.WriteLine(批处理作业调度.x2[i]);
            }
            //初始化第一个序列，从1开始到number 
            for (i = 1; i <= 批处理作业调度.number; i++)
            {
                批处理作业调度.order[i] = i;
            }
            
            批处理作业调度.backtrack(1);
            Console.WriteLine($"最节省的时间为：{ 批处理作业调度.bestsum }");
            Console.Write("对应的方案为：");
            for (i = 1; i <= 批处理作业调度.number; i++) 
                Console.Write($"{批处理作业调度.bestorder[i]}  ");

            Console.WriteLine();

            #endregion

            #region 符号三角形问题

            int n = 4;
            Console.WriteLine($"请输入第一行符号值：{n}");
            
            符号三角形问题 符号三角形问题 = new 符号三角形问题();
            Console.WriteLine("个数：" + 符号三角形问题.computs(n));

            #endregion

            #region n后问题

            n后问题.queensNum = 8;
            n后问题 n后问题_ = new n后问题();
            Console.WriteLine($"皇后的个数:{n后问题.queensNum}");
            n后问题_.init();
            // 从第 1 列开始求解  
            n后问题_.testing(1);

            #endregion

            #region 0_1背包问题

            Console.WriteLine("输入的样例：物品数量：4");
            Console.WriteLine("背包容量：9");
            Console.WriteLine("重量分别是：2 3 4 5");
            Console.WriteLine("价值分别是：3 4 5 6 ");

            _0_1背包问题 _0_1背包问题 = new _0_1背包问题();

            int num = 4;
            int[] weight = new int[4] { 2, 3, 4, 5 };
            int[] valueAll = new int[4] { 3, 4, 5, 6 };
            _0_1背包问题.bagProblem(0, weight, valueAll);
            Console.WriteLine($"最终的结果是： { _0_1背包问题.value }");

            #endregion

            #region 

            图着色问题 图着色问题 = new 图着色问题();
            Console.WriteLine("输入顶点数和颜色数量：");
            图着色问题.v = 5;
            图着色问题.c = 4;
            //输入邻接矩阵 
            图着色问题.graph = new int[,] {
                { 0, 0 ,0 ,0 ,0 ,0 },
                { 0, 0 ,1 ,1 ,1 ,0 },
                { 0,  1 ,0 ,1 ,1 ,1 },
                { 0, 1 ,1 ,0 ,1 ,0 },
                { 0, 1 ,1 ,1 ,0 ,1 },
                { 0, 0 ,1 ,0 ,1 ,0 },
            };
            for (int 图着色问题i = 1; 图着色问题i <= 图着色问题.v; 图着色问题i++)
            {
                for (int j = 1; j <= 图着色问题.v; j++)
                {
                    Console.Write(图着色问题.graph[图着色问题i,j]);
                }
                Console.WriteLine();
            }
            图着色问题.backtrace(1);
            Console.WriteLine($"图着色问题 {图着色问题.sum}");

            #endregion

            Console.ReadLine();
        }
    }
}
