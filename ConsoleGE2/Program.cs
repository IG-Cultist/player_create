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
            Player player = new Player();
            player.CreatePlayer();
            player.ShowPlayer();
            player.PlayerBattle();
        }
    }


}