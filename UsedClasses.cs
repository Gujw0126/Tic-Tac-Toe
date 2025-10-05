using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tac
{
    internal class Player//玩家类
    {
        public string name { get; set; }
        public int chess { get; set; }//o=1,x=-1
        public int win { get; set; }
        public int lost { get; set; }
        public int draw { get; set; }
        public Player(string player_name, object mychess)
        {
            name = player_name;
            if (mychess.ToString() == "O")
                chess = 1;
            else chess = -1;
            win = lost = draw = 0;
        }

    }
    internal class Board//棋盘类
    {
        private int[,] Vs { get; set; }
        public Board()
        {
            Vs = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Vs[i, j] = 0;
        }
        private bool IsBoardEmpty(int x, int y)//该位置是否为空
        {
            if (x < 0 || x >= 3 || y < 0 || y >= 3 || Vs[x, y] != 0)
            {
                return false;
            }
            else return true;
        }
        public bool PutChess(int x, int y, int charchess)
        {
            if (charchess == 1)
            {
                if (IsBoardEmpty(x, y))
                {
                    Vs[x, y] = 1;
                    return true;
                }
            }
            else
            {
                if (IsBoardEmpty(x, y))
                {
                    Vs[x, y] = -1;
                    return true;
                }
            }
            return false;//下棋失败
        }
        public int CheckWin()//判断结果
        {
            int flag = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (Vs[i, j] == 0)
                        flag = 1;//棋盘未满
            if (Vs[0, 0] == 1 && Vs[0, 1] == 1 && Vs[0, 2] == 1 ||
                Vs[1, 0] == 1 && Vs[1, 1] == 1 && Vs[1, 2] == 1 ||
                Vs[2, 0] == 1 && Vs[2, 1] == 1 && Vs[2, 2] == 1 ||
                Vs[0, 0] == 1 && Vs[1, 0] == 1 && Vs[2, 0] == 1 ||
                Vs[0, 1] == 1 && Vs[1, 1] == 1 && Vs[2, 1] == 1 ||
                Vs[0, 2] == 1 && Vs[1, 2] == 1 && Vs[2, 2] == 1 ||
                Vs[0, 0] == 1 && Vs[1, 1] == 1 && Vs[2, 2] == 1 ||
                Vs[0, 2] == 1 && Vs[1, 1] == 1 && Vs[2, 0] == 1)
            {
                return 1;//o赢
            }
            else if (Vs[0, 0] == -1 && Vs[0, 1] == -1 && Vs[0, 2] == -1 ||
                Vs[1, 0] == -1 && Vs[1, 1] == -1 && Vs[1, 2] == -1 ||
                Vs[2, 0] == -1 && Vs[2, 1] == -1 && Vs[2, 2] == -1 ||
                Vs[0, 0] == -1 && Vs[1, 0] == -1 && Vs[2, 0] == -1 ||
                Vs[0, 1] == -1 && Vs[1, 1] == -1 && Vs[2, 1] == -1 ||
                Vs[0, 2] == -1 && Vs[1, 2] == -1 && Vs[2, 2] == -1 ||
                Vs[0, 0] == -1 && Vs[1, 1] == -1 && Vs[2, 2] == -1 ||
                Vs[0, 2] == -1 && Vs[1, 1] == -1 && Vs[2, 0] == -1)
            {
                return -1;//x赢
            }
            else if (flag == 0)
                return 0;//和棋 
            else return 2;//游戏未结束
        }
    }
    static class Global
    {
        public static Board game;
        public static Player player1;
        public static Player player2;
        public static int turn;
    }
}
