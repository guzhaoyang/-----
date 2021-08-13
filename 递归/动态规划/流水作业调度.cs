/***************************
 * 
 * 
 * https://www.cnblogs.com/wkfvawl/p/11667092.html
 * 
 * 
 * ************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace 动态规划
{
    public class 流水作业调度
    {
        public class JOB
        {
            public int key, index;
            public bool job;
        }

        public class JobIComparer : IComparer<JOB>
        {
            public int Compare(JOB a, JOB b)
            {
                return a.key < b.key? 1:0;
            }
        }

        public int func(int n, int[] a, int[] b, int[] c)
        {
            int i, j, k;
            JOB[] d = new JOB[n];
            for (i = 0; i < n; i++)
            {
                d[i] = new JOB();
                if (a[i] < b[i])
                {

                    d[i].job = true;
                    d[i].key = a[i];
                }
                else
                {
                    d[i].job = false;
                    d[i].key = b[i];
                }
                d[i].index = i;
            }
            Array.Sort(d, new JobIComparer());

            j = 0; k = n - 1;
            for (i = 0; i < n; i++)
            {
                if (d[i].job == true)
                    c[j++] = d[i].index;
                else
                    c[k--] = d[i].index;
            }
            j = a[c[0]];
            k = j + b[c[0]];
            for (i = 1; i < n; i++)
            {
                j = j + a[c[i]];
                k = j < k ? k + b[c[i]] : j + b[c[i]];
            }
            return k;
        }
    }
}
