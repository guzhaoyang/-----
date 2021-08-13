/********************************
 * 
 * https://blog.csdn.net/cxh_1231/article/details/83061510
 * 
 * *****************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 分治
{
    public class 循环赛日程安排
    {

        public int[,] calendar = new int[100, 100];  //日程表数组


		public void GameTable(int k, int[, ] a)
		{
			// n=2^k(k≥1)个选手参加比赛
			//二维数组a表示日程安排，数组下标从1开始
			int n = 2;  //k=0，2个选手比赛日程可直接求得
						//求解2个选手比赛日程，得到左上角元素
			a[1,1] = 1; a[1,2] = 2;
			a[2,1] = 2; a[2,2] = 1;
			for (int t = 1; t < k; t++)
			//迭代处理，依次处理2^2, …, 2^k个选手比赛日程
			{
				int temp = n; n = n * 2;
				//填左下角元素
				for (int i = temp + 1; i <= n; i++)
					for (int j = 1; j <= temp; j++)
						a[i,j] = a[i - temp,j] + temp;
				//左下角元素和左上角元素的对应关系
				//填右上角元素
				for (int i = 1; i <= temp; i++)
					for (int j = temp + 1; j <= n; j++)
						a[i,j] = a[i + temp,(j + temp) % n];
				//填右下角元素
				for (int i = temp + 1; i <= n; i++)
					for (int j = temp + 1; j <= n; j++)
						a[i,j] = a[i - temp,j - temp];
			}
		}

		public void PrintTable(int k, int[,] a)
		{
			double n = Math.Pow((double)2, k);
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n; j++)
				{
					Console.Write($"{a[i,j]}　 ");
				}
				Console.WriteLine();
			}
		}

	}
}
