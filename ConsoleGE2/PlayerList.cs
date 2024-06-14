using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGE2
{
    class PlayerList
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
        public PlayerList(string _name, int _hp, int _atk)
        {

        }
        List<PlayerList> list = new List<PlayerList>();

        List<PlayerList> GetList(string _name, int _hp, int _atk)
        {
            _name = name;
            _hp = hp;
            _atk = atk;
            return list;
        }
    }
}
