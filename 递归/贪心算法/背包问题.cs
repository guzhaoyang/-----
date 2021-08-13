/********************************
 * 
 * https://blog.csdn.net/ljmingcom304/article/details/50310789
 * 
 * ******************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace 贪心算法
{
    public class Knapsack
    {
        /** 物品重量 */
        public int weight;
        /** 物品价值 */
        public int value;
        /** 单位重量价值 */
        public int unitValue;

        public Knapsack(int weight, int value)
        {
            this.weight = weight;
            this.value = value;
            this.unitValue = (weight == 0) ? 0 : value / weight;
        }

        public int getWeight()
        {
            return weight;
        }

        public void setWeight(int weight)
        {
            this.weight = weight;
        }

        public int getValue()
        {
            return value;
        }

        public void setValue(int value)
        {
            this.value = value;
        }

        public int getUnitValue()
        {
            return unitValue;
        }
    }

    public class KnapsackIComparable: IComparer<Knapsack>
    {
        public int Compare(Knapsack x, Knapsack y)
        {
            if (x.unitValue > y.unitValue) return 1;
            else return 0;
        }

    }

    /// <summary>
    /// 按照贪心算法将物品放入背包中
    /// </summary>
    public class TXSFProblem
    {
        // 现有的物品
        private Knapsack[] bags;
        // 背包的总承重
        private int totalWeight;
        // 背包最大总价值
        private int bestValue;

        public TXSFProblem(Knapsack[] bags, int totalWeight)
        {            
            this.bags = bags;
            this.totalWeight = totalWeight;
            // 对背包按单位重量价值从大到小排序
            Array.Sort<Knapsack>(bags, 0, bags.Length, new KnapsackIComparable());
        }

        public void solve()
        {
            int tempWeight = totalWeight;

            for (int i = 0; i < bags.Length; i++)
            {
                //判断当前物品是否可以放入背包中，若不能则继续循环，查找下一个物品
                if (tempWeight - bags[i].getWeight() < 0)
                    continue;

                tempWeight -= bags[i].getWeight();
                bestValue += bags[i].getValue();
            }
        }

        public int getBestValue()
        {
            return bestValue;
        }
    }
}
