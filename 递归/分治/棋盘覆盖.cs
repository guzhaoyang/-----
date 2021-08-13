/*************************
*
*https://www.cnblogs.com/wkfvawl/p/11461406.html
*
**************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace 分治
{
    public class 棋盘覆盖
    {
        static int tile = 0;
        public static int[,] board = new int[150,150];

        public void chessBoard(int tr, int tc, int dr, int dc, int size)
        {
            if (size == 1)
            {
                return;
            }
            int t = ++tile;//L型骨牌编号
            int s = size / 2;//分割棋盘
                             //覆盖左上角的棋盘
            if (dr < tr + s && dc < tc + s)
            {
                //特殊方格在此棋盘中
                chessBoard(tr, tc, dr, dc, s);
            }
            else
            {
                //此棋盘中无特殊方格
                //用t号L型方格覆盖右下角
                board[tr + s - 1,tc + s - 1] = t;
                chessBoard(tr, tc, tr + s - 1, tc + s - 1, s);
            }
            //覆盖右上角子棋盘
            if (dr < tr + s && dc >= tc + s)
            {
                chessBoard(tr, tc + s, dr, dc, s);
            }
            else
            {
                //此棋盘中无特殊方格
                //用t号L型方格覆盖左下角
                board[tr + s - 1,tc + s] = t;
                chessBoard(tr, tc + s, tr + s - 1, tc + s, s);
            }
            //覆盖左下角子棋盘
            if (dr >= tr + s && dc < tc + s)
            {
                chessBoard(tr + s, tc, dr, dc, s);
            }
            else
            {
                //此棋盘中无特殊方格
                //用t号L型方格覆盖右上角
                board[tr + s, tc + s - 1] = t;
                chessBoard(tr + s, tc, tr + s, tc + s - 1, s);
            }
            //覆盖右下角子棋盘
            if (dr >= tr + s && dc >= tc + s)
            {
                chessBoard(tr + s, tc + s, dr, dc, s);
            }
            else
            {
                //此棋盘中无特殊方格
                //用t号L型方格覆盖左上角
                board[tr + s, tc + s] = t;
                chessBoard(tr + s, tc + s, tr + s, tc + s, s);
            }
        }
    }
}
