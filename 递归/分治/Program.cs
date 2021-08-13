using System;

namespace 分治
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            二分搜索 二分搜索 = new 二分搜索();
            int n = 二分搜索.BinarySearch(二分搜索.array, 5);
            Console.WriteLine(n);

            /******************
             * 
             * 矩阵乘法的Strassen算法详解
             * https://blog.csdn.net/zhengqijun_/article/details/53357682
             * https://www.cnblogs.com/hdk1993/p/4552534.html
             * 
             * ****************/

            #region 棋盘覆盖

            int k, tr, tc, dc, dr;
            k = 2;
            dr = 1;
            dc = 1;
            int size = (int)Math.Pow(2, k);
            棋盘覆盖 ch = new 棋盘覆盖();
            ch.chessBoard(0, 0, dr, dc, size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(棋盘覆盖.board[i,j] + " ");
                }
                Console.WriteLine();
            }

            #endregion

            #region 自然合并排序 已注释

            //自然合并排序 自然合并排序 = new 自然合并排序();
            //Console.WriteLine("自然合并排序前");
            //foreach (var item in 自然合并排序.array)
            //{
            //    Console.Write($"{item}  ");
            //}
            //Console.WriteLine();
            //自然合并排序.mergeSort(自然合并排序.array);
            //Console.WriteLine("自然合并排序后");
            //foreach (var item in 自然合并排序.array)
            //{
            //    Console.Write($"{item}  ");
            //}
            //Console.WriteLine();

            #endregion

            #region 循环赛日程安排

            int kk = 3;            
            Console.WriteLine("日程表如下");
            循环赛日程安排 循环赛日程安排 = new 循环赛日程安排();
            循环赛日程安排.GameTable(kk, 循环赛日程安排.calendar);
            循环赛日程安排.PrintTable(kk, 循环赛日程安排.calendar);


            #endregion

            Console.ReadLine();
        }
    }
}
