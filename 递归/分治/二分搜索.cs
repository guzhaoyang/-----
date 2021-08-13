using System;
using System.Collections.Generic;
using System.Text;

namespace 分治
{
    public class 二分搜索
    {
        //已排好序的数组
        public int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9 };

        /// <summary>
        /// 查找v在有序数组array中的位置
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] array, int v)
        {
            if (array == null || array.Length == 0) return -1;
            int begin = 0;
            int end = array.Length;
            while (begin < end)
            {
                int mid = (begin + end) >> 1;//向右移一位，等同于除以2
                if (v < array[mid])
                {
                    end = mid;//搜索的值在左侧
                }
                else if (v > array[mid])
                {
                    begin = mid + 1;//搜索的值在右侧
                }
                else
                {
                    return mid;//刚好等于中间的位置
                }
            }
            return -1;
        }
    }
}
