/************************
 * 
 * 合并排序（分治）
 * https://www.cnblogs.com/wkfvawl/p/11480419.html
 * 
 * *********************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 分治
{
    public class 自然合并排序
    {
        public int[] array = { 8, 4, 5, 7, 1, 3, 6, 2 };

        public static void mergeSort(int[] a)
        {
            int[] b = new int[a.Length];
            int s = 1;
            while (s < a.Length)
            {
                mergePass(a, b, s);          //合并到数组b
                s += s;
                mergePass(b, a, s);          //合并回数组a
                s += s;
            }
        }

        public static void mergePass(int[] x, int[] y, int s)
        {
            int i = 0;
            while (i <= x.Length - 2 * s)
            {
                merge(x, y, i, i + s - 1, i + 2 * s - 1);
                i = i + 2 * s;
            }
            if (i + s < x.Length)            //剩下的元素个数少于2s
            {
                merge(x, y, i, i + s - 1, x.Length - 1);
            }
            else
            {
                //复制到y
                for (int j = i; j < x.Length; j++)
                {
                    y[j] = x[j];
                }
            }
        }

        /// <summary>
        /// 算法有问题，暂时不知道怎么解决
        /// </summary>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <param name="r"></param>
        public static void merge(int[] c, int[] d, int l, int m, int r)
        {
            int i = 1;
            int j = m + 1;
            int k = l;
            while ((i <= m) && (j <= r))
            {
                if (c[i] <= c[j])  //c[i]<c[j]
                {
                    d[k++] = c[i++];
                }
                else                         //c[i]>c[j]
                {
                    d[k++] = c[j++];
                }
            }
            //将剩下的元素存到数组中
            while (i <= m)
            {
                d[k++] = c[i++];
            }
            while (j <= r)
            {
                d[k++] = c[j++];
            }
        }
    }
}
