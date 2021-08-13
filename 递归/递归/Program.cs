using System;

namespace 递归
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = factorial(10);
            Console.WriteLine($"阶乘：{n}");

            n = Fibonacci(10);
            Console.WriteLine($"斐波那契数列：{n}");

            Console.WriteLine("汉诺塔开始");
            Hanoi(10, 'A', 'B', 'C');
            Console.WriteLine("汉诺塔结束");

            Console.ReadKey();
        }

        /// <summary>
        /// 阶乘!
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int factorial(int n)
        {
            if (n == 0) return 1;
            return n * factorial(n - 1);
        } 

        /// <summary>
        /// 斐波那契数列
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int Fibonacci(int n)
        {
            if (n <= 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /// <summary>
        /// 汉诺塔
        /// https://www.cnblogs.com/destiny1123/articles/4242398.html
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        private static void Hanoi(int n, char a, char b, char c)//这里代表将a柱子上的盘子借助b柱子移动到c柱子
        {
            if (1 == n)                                //如果是一个盘子直接将a柱子上的盘子移动到c
            {
                Console.WriteLine($"{a}-->{c}");
            }
            else
            {
                Hanoi(n - 1, a, c, b);                  //将a柱子上n-1个盘子借助c柱子，移动到b柱子
                Console.WriteLine($"{a}-->{c}");        //再直接将a柱子上的最后一个盘子移动到c
                Hanoi(n - 1, b, a, c);                  //然后将b柱子上的n-1个盘子借助a移动到c
            }
         }
    }
}
