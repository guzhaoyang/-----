/**********************************
 * 
 * https://blog.csdn.net/jeffleo/article/details/54578247
 * 
 * *******************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 回溯法
{
    public class 批处理作业调度
    {
        public const int MAX = 200;

        public int number;//作业数量
        public int[] x1 = new int[10];//作业在机器1运行的时间
        public int[] x2 = new int[10];//作业在机器2运行的时间
        public int sum = 0;//作业完成的总时间 
        public int bestsum = MAX;//作业完成的最优时间 
        public int[] order = new int[10];//作业完成的次序,要用于交换
        public int[] bestorder = new int[10];//作业完成的最优的顺序
        public int f1 = 0;//机器1累计的时间 
        public int[] f2 = new int[10];//作业在机器2处理完累计的时间，即每一个作业的调度时间
        public int[] vis = new int[10];//记录作业以否已被选 

        public void backtrack(int cur)
        {
            //cur表示正在赋值的位置，cur+1去到下一层子节点，i递增，在当前层遍历兄弟节点
            if (cur > number)
            {
                for (int i = 1; i <= number; i++) bestorder[i] = order[i];
                bestsum = sum;
            }
            else
            {
                for (int i = 1; i <= number; i++)
                { //遍历number，尝试填第一位
                    if (vis[i] == 0)
                    {
                        vis[i] = 1;
                        f1 += x1[i];
                        //本作业的在机器1的处理时间 和 上一个作业在机器2的处理时间的较大时间（因为两者是同时进行的）
                        f2[cur] = (f2[cur - 1] > f1 ? f2[cur - 1] : f1) + x2[i];
                        sum += f2[cur];
                        order[cur] = i;
                        if (sum < bestsum)
                        {//剪枝，如果当前sum都大于bestsum了，则不再遍历此节点 
                            backtrack(cur + 1);
                        }
                        //每计算一次，为了不影响父节点和兄弟节点，运算完都要复位
                        sum -= f2[cur];
                        f1 -= x1[i];
                        vis[i] = 0;
                    }
                }
            }
        }
    }
}
