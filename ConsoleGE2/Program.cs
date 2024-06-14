using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.CreatePlayer();
            player.ShowPlayer();
        }
    }

    class Player
    {
        private string[] name = new string[2];
        private string[] hp = new string[2];
        private string[] atk = new string[2];
        public void CreatePlayer()
        {
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


    }
}