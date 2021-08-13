/***********************************
 * 
 * https://bbs.huaweicloud.com/blogs/detail/265075
 * 
 * *********************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 回溯法
{
    public class _0_1背包问题
    {
        //用于记录是否存放当前地物体
        public int[] inOut = new int[4];
        //保存最多的价值
        public int value;
        //定义背包的总共的重量的
        public int bagVolume = 9;

		/*
			描述：背包问题的约束条件，当传入对应的序号，就去判定是否要放对应的物品
			参数：放入包中物体的序号
			返回：当前物体总重量和背包容量的关系 true：表示没有超重 false：表示超重
			原理：判定当前的物品的总重量，是不是小于物体的实际重量
		*/
		public bool bagConstraint(int m, int[] weight)
		{
			//一直遍历m层之前的所有物体，求出其对应的重量
			int allweight = 0;
			for (int i = 0; i <= m; ++i)
			{
				//计算出总共的重量的
				allweight += inOut[i] * weight[i];
			}

			//比较当前的物体总重量和背包的总重量关系
			return allweight <= bagVolume;
		}

		/*
			描述：深度优先搜索的函数，递归函数
			参数：m:是要装入背包的物品的数量 weight：是背包中各个物品的重量 value：是背包中各个物品的价值
			返回：最终返回的是最大的价值
			问题：
		*/
		public void bagProblem(int m, int[] weight, int[] valueAll)
		{

			//首先确定终止条件，那就比较最大值
			if (m == 4)
			{
				int sum = 0;
				for (int i = 0; i < m; ++i)
				{
					sum += valueAll[i] * inOut[i];
				} //比较最大值
				if (sum > value)
				{
					value = sum;
				}
			}
			else
			{
				//没有到达终止条件，继续向下进行递归
				for (int i = 0; i < 2; ++i)
				{
					inOut[m] = i; //判定是否满足对应约束条件
					if (bagConstraint(m, weight)) 
					{ 
						//满足约束条件，继续向下进行递归的
						bagProblem(m + 1, weight, valueAll); 
					}
				}
			}
		}

	}
}
