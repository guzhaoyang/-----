using System;

namespace 动态规划
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region 电路布线

            int[] a = { 0, 8, 7, 4, 2, 5, 1, 9, 3, 10, 6 };
            int[,] set = new int[11,11];

            电路布线 电路布线 = new 电路布线();

            电路布线.circut(a, set, 10);

            Console.WriteLine($"max set: {set[10, 10]} ");
            电路布线.back_track(10, 10, set);
            Console.WriteLine();

            #endregion

            #region 流水作业调度

            int i, n, m;
            int[] a流水作业调度 = new int[100];
            int[] b流水作业调度 = new int[100];
            int[] c = new int[100];

            m = 7;
            a流水作业调度[0] = 5;
            b流水作业调度[0] = 2;

            a流水作业调度[1] = 3;
            b流水作业调度[1] = 4;

            a流水作业调度[2] = 6;
            b流水作业调度[2] = 7;

            a流水作业调度[3] = 4;
            b流水作业调度[3] = 2;

            a流水作业调度[4] = 8;
            b流水作业调度[4] = 9;

            a流水作业调度[5] = 9;
            b流水作业调度[5] = 7;

            a流水作业调度[6] = 6;
            b流水作业调度[6] = 3;

            流水作业调度 流水作业调度 = new 流水作业调度();
            var 流水作业调度_result = 流水作业调度.func(m, a流水作业调度, b流水作业调度, c);
            Console.WriteLine(流水作业调度_result);

            #endregion

            #region _0_1背包问题

            int _0_1背包问题m, _0_1背包问题n, _0_1背包问题i, _0_1背包问题j;
            int ret;

            _0_1背包问题m = 10;        //背包容量
            _0_1背包问题n = 3;        //物品个数

            //scanf("%d%d",&m,&n);
            _0_1背包问题 _0_1背包问题 = new _0_1背包问题();

            for (_0_1背包问题i = 0; _0_1背包问题i <= _0_1背包问题m; _0_1背包问题i++)
                for (_0_1背包问题j = 0; _0_1背包问题j <= _0_1背包问题n; _0_1背包问题j++)
                    _0_1背包问题.value[_0_1背包问题i, _0_1背包问题j] = 0;

            ret = _0_1背包问题.package(_0_1背包问题m, _0_1背包问题n);

            Console.WriteLine($"0_1背包问题: {ret}");

            #endregion


            Console.ReadKey();
        }
    }
}
