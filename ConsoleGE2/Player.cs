using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGE2
{
    class Player
    {
        //---------------------------
        // フィールド
        //---------------------------
        // プレイヤー名
        private string name;
        // 体力
        private int hp;
        // 攻撃力
        private int atk;
        public Player(string _name, int _hp, int _atk)
        {
            _name = "";
            _hp = 1;
            _atk = 1;
        }
        //プレイヤー保存クラス
        PlayerList[] playerList = new PlayerList[2];

        //---------------------------
        // メソッド
        //---------------------------
        public void CreatePlayer(int num)
        {
            Console.Clear();
            string hpStr;
            string atkStr;
            Console.Write("名前を入力:");
            name = Console.ReadLine();

            while (true)
            {
                Console.Write("体力を入力:");
                hpStr = Console.ReadLine();
                if (int.TryParse(hpStr, out hp)) break;
                else Console.WriteLine("数値を入力してください");
            }

            while (true)
            {
                Console.Write("攻撃力を入力:");
                atkStr = Console.ReadLine();
                if (int.TryParse(atkStr, out atk)) break;
                else Console.WriteLine("数値を入力してください");
            }
            
            playerList[num] = new PlayerList(name, hp, atk);
        }

        public void ShowPlayer()
        {
            Console.Clear();
            if (name == null)
            {
                Console.WriteLine("まだプレイヤーがいません");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("=============================");
            Console.WriteLine(name + "のステータス");
            Console.WriteLine("=============================");
            Console.WriteLine("HP:" + hp);
            Console.WriteLine("ATK:" + atk);
            Console.WriteLine("=============================");
            Console.ReadLine();
        }
    }
}
