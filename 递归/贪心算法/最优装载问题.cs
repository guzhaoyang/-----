/*****************************
 * 
 * https://www.cnblogs.com/blogtech/p/12291028.html
 * 
 * ***************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 贪心算法
{
    public class ExcellentLoading
    {

        /**
         * 轮船的最大容量
         */
        private static int total = 0;

        /**
         * 轮船装完物品，剩余重量
         */
        private static int residueTotal = 0;

        /**
         * 装入的物品个数
         */
        private static int num = 0;

        /**
         * 物品重量数组
         */
        private static int[] weight;

        /**
         * 物品存放数组【1：存放  0：不存放】
         */
        private static int[] store;

        /**
         * 初始化数据
         */
        public static void initData()
        {
            total = 20;
            Console.WriteLine($"请输入轮船的总重量:{total}");
            num = 6;
            Console.WriteLine($"请输入要装入的物品个数:{num}");
            
            Console.WriteLine("请输入各物品的重量:");
            weight = new int[num];
            weight[0] = 1;
            weight[1] = 4;
            weight[2] = 8;
            weight[3] = 6;
            weight[4] = 9;
            weight[5] = 3;

            store = new int[num];
            for (int i = 0; i < weight.Length; i++)
            {
                Console.WriteLine($"{weight[i]}");    //每个物品的重量
                store[i] = 0;                   //初始化物品都不存放
            }
        }

        /**
         * 按物品重量由小到大升序排序，同时调整物品序号
         */
        public static void weightSort()
        {
            int change = 1;
            int temp;
            for (int i = 0; i < weight.Length - 1 && change == 1; i++)
            {
                change = 0;
                for (int j = 0; j < weight.Length - 1 - i; j++)
                {
                    if (weight[j] > weight[j + 1])
                    {
                        // 交换重量数组
                        temp = weight[j];
                        weight[j] = weight[j + 1];
                        weight[j + 1] = temp;

                        change = 1; //避免不必要的排序操作
                    }
                }
            }
        }

        /**
         * 统计最优装载
         */
        public static void excellentLoading()
        {
            residueTotal = total;
            for (int i = 0; i < weight.Length && weight[i] <= residueTotal; i++)
            {
                store[i] = 1;     // 轮船存放物品
                residueTotal = residueTotal - weight[i];  // 轮船剩余重量
            }
        }

        /**
         * 输出函数
         */
        public static void print()
        {
            Console.WriteLine("轮船最大容量: total = " + total + "，轮船剩余容量: residueTotal = " + residueTotal);
            Console.WriteLine("排序完物品数组: ");
            foreach (var item in weight)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            Console.WriteLine("物品存放数组: ");
            foreach (var item in store)
            {
                Console.Write($"{item}  ");
            }
        }
    }
}
