/**********************************
 * 
 * https://blog.csdn.net/wuthering_wind/article/details/80202446
 * 
 * *******************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 贪心算法
{
    public class 活动安排问题
    {
        public const int M = 11;
		public const int MAX = 2000;

		public void select(int num, int[] s, int[] f)
		{
			int preStart = 0;
			int preFinal = MAX;//保证是无限大即可
			int i;
			int temp = 0;
			int OK = 1;
			int[] sel = new int [M];//用来储存相容的活动编号 
			int selNum = 0;

			while (OK == 1)
			{
				OK = 0;
				for (i = 0; i < M; i++)
				{

					if (f[i] < preFinal && s[i] >= preStart)
					{//寻找开始时间合适地情况下结束时间最早者 
						preFinal = f[i];
						temp = i;
						OK = 1;
						Console.WriteLine($"{s[i]}-------------->{f[i]}");
					}
				}

				if (preFinal != MAX)
				{  //变量的重新赋值 
					sel[selNum++] = temp;
					preStart = f[temp];
					preFinal = MAX;
				}
			}
			Console.WriteLine($"{selNum}");//相容数量 
		}

    }
}
