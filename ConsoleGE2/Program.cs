using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[2];
            for (int i = 0; i < 2; i++)
            { //初期化
                players[i] = new Player("", 1, 1);
            }
            while (true)
            {
                Console.WriteLine("命令は？");
                Console.Write("[1:プレイヤー生成 2:プレイヤー一覧 3:戦闘 4:終了]>");
                string codeStr = Console.ReadLine();

                if (int.TryParse(codeStr, out int code))
                {
                    if (code == 1)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            players[i] = new Player("", 1, 1);
                            players[i].CreatePlayer(i);
                        }
                    }
                    else if (code == 2)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            players[i].ShowPlayer();
                        }
                    }
                    //else if (code == 3) player.PlayerBattle();
                    else if (code == 4) break;
                    else Console.WriteLine("存在しない命令です");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("読み取りに失敗");
                    Console.ReadLine();
                }
                Console.Clear();
            }
        }
    }
}