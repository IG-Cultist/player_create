using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGE2
{
    class Playerrrr
    {
        private string[] name = new string[2];
        private string[] hp = new string[2];
        private string[] atk = new string[2];
        public void CreatePlayer()
        {
            //2人分のステータスを記入
            for (int i = 0; i < 2; i++)
            {
                Console.Write((i + 1) + "人目の名前を入力:");
                name[i] = Console.ReadLine();

                Console.Write((i + 1) + "人目の体力を入力:");
                hp[i] = Console.ReadLine();

                Console.Write((i + 1) + "人目の攻撃力を入力:");
                atk[i] = Console.ReadLine();
            }
        }

        public void ShowPlayer()
        {
            //各ステータスを表示
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(name[i] + "のステータス");
                Console.WriteLine("HP:" + hp[i]);
                Console.WriteLine("ATK:" + atk[i]);
            }
            Console.ReadLine();
        }

        public void PlayerBattle()
        {
            int[] HP = new int[2];
            int[] ATK = new int[2];
            int nowTurn = 0;
            int waitTurn = 1;

            // 各ステータスをint化
            for (int i = 0; i < 2; i++)
            {
                int.TryParse(hp[i], out HP[i]);
                int.TryParse(atk[i], out ATK[i]);
            }

            // どちらかのHPが0になるとループ終了
            while (true)
            {
                Console.WriteLine(name[nowTurn] + "の攻撃！" + name[waitTurn] + "に" + ATK[nowTurn] + "ダメージ");
                HP[waitTurn] -= ATK[nowTurn]; // 現在ターンプレイヤーの攻撃力分待機中プレイヤーの体力を減らす

                // 0を下回った場合、0に再設定する
                if (HP[waitTurn] <= 0)
                {
                    HP[waitTurn] = 0;
                }
                Console.WriteLine(name[nowTurn] + "[HP:" + HP[nowTurn] + "]");
                Console.WriteLine(name[waitTurn] + "[HP:" + HP[waitTurn] + "]");
                Console.ReadLine();

                // 0を下回った場合
                if (HP[waitTurn] <= 0)
                {
                    Console.WriteLine(name[nowTurn] + "の勝ち");
                    Console.ReadLine();
                    break;
                }
                else
                {// ターン切り替え
                    if (nowTurn == 0)
                    {
                        nowTurn = 1;
                        waitTurn = 0;
                    }
                    else
                    {
                        nowTurn = 0;
                        waitTurn = 1;
                    }
                }
            }
        }
    }
}
