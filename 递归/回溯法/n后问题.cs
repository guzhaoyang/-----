/******************************
 * 
 * https://developer.aliyun.com/article/420510
 * 
 * ****************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 回溯法
{
    public class n后问题
    {
        // 皇后的个数  
        public static int queensNum = 4;

        // column[i] = j 表示第 i 列的第 j 行放置一个皇后  
        private int[] queens = new int[queensNum + 1];

        // rowExists[i] = true 表示第 i 行有皇后  
        private bool[] rowExists = new bool[queensNum + 1];

        // a[i] = true 表示右高左低的第 i 条斜线有皇后  
        private bool[] a = new bool[queensNum * 2];

        // b[i] = true 表示左高右低的第 i 条斜线有皇后  
        private bool[] b = new bool[queensNum * 2];

        // 初始化变量  
        public void init()
        {
            for (int i = 0; i < queensNum + 1; i++)
            {
                rowExists[i] = false;
            }

            for (int i = 0; i < queensNum * 2; i++)
            {
                a[i] = b[i] = false;
            }
        }

        // 判断该位置是否已经存在一个皇后,存在则返回 true  
        private bool isExists(int row, int col)
        {
            return (rowExists[row] || a[row + col - 1] || b[queensNum + col - row]);
        }

        // 主方法：测试放置皇后  
        public void testing(int column)
        {

            // 遍历每一行  
            for (int row = 1; row < queensNum + 1; row++)
            {
                // 如果第 row 行第 column 列可以放置皇后  
                if (!isExists(row, column))
                {
                    // 设置第 row 行第 column 列有皇后   
                    queens[column] = row;
                    // 设置以第 row 行第 column 列为交叉点的斜线不可放置皇后  
                    rowExists[row] = a[row + column - 1] = b[queensNum + column - row] = true;

                    // 全部尝试过，打印  
                    if (column == queensNum)
                    {
                        for (int col = 1; col <= queensNum; col++)
                        {
                            Console.Write("(" + col + "," + queens[col] + ")  ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        // 放置下一列的皇后  
                        testing(column + 1);
                    }
                    // 撤销上一步所放置的皇后，即回溯  
                    rowExists[row] = a[row + column - 1] = b[queensNum + column - row] = false;
                }
            }
        }
    }
}
