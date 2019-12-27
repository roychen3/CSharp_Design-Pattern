using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    // 儲存資料
    class Memento
    {
        private int _hp;
        private int _exp;

        public Memento(int hp, int exp)
        {
            this.hp = hp;
            this.exp = exp;
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
