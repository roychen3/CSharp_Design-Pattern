using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    // 玩家 (Originator class)
    class Player
    {
        private int _hp = 100; // 體力
        private int _exp = 0; // 經驗值

        // 儲存資料
        public Memento saveToMemento()
        {
            // 將要儲存的資料傳給 Memento 物件
            return (new Memento(this._hp, this._exp));
        }

        // 回復資料
        public void loadFromMemento(Memento m)
        {
            this._hp = m.hp;
            this._exp = m.exp;
        }

        // 體力、經驗值 增減
        public void run(int hp, int exp)
        {
            this._hp += hp;
            this._exp += exp;
        }

        public int hp
        {
            get { return this._hp; }
            set { this._hp = value; }
        }

        public int exp
        {
            get { return this._exp; }
            set { this._exp = value; }
        }

    }
}
