using System;

namespace 贪心算法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region 活动安排问题

            活动安排问题 活动安排问题 = new 活动安排问题();

            int[] s = new int[] { 1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12 };
            int[] f = new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            活动安排问题.select(活动安排问题.M, s, f);

            #endregion

            #region 背包问题

            Knapsack[] bags = new Knapsack[] { new Knapsack(2, 13),
                new Knapsack(1, 10), new Knapsack(3, 24), new Knapsack(2, 15),
                new Knapsack(4, 28), new Knapsack(5, 33), new Knapsack(3, 20),
                new Knapsack(1, 8) };
            int totalWeight = 12;

            TXSFProblem problem = new TXSFProblem(bags, totalWeight);
            problem.solve();

            Console.WriteLine($"0/1背包问题： {problem.getBestValue()}");

            #endregion

            #region 最优装载问题

            // 初始化数据
            ExcellentLoading.initData();
            // 排序【按重量由小到大】
            ExcellentLoading.weightSort();
            // 统计最优装载
            ExcellentLoading.excellentLoading();
            // 输出
            ExcellentLoading.print();

            Console.WriteLine();

            #endregion

            #region 多机调度
            多机调度 多机调度 = new 多机调度();
            int[] time = new int[多机调度.N] { 16, 14, 6, 5, 4, 3, 2 };//处理时间按从大到小排序 
            int maxtime = 0;
            if (多机调度.M >= 多机调度.N)
            {
                maxtime = 多机调度.setwork1(time, 多机调度.N);
            }
            else
            {
                maxtime = 多机调度.setwork2(time, 多机调度.N);
            }
            Console.WriteLine($"最多耗费时间{maxtime}。");

            #endregion

            Console.ReadKey();
        }
    }
}
