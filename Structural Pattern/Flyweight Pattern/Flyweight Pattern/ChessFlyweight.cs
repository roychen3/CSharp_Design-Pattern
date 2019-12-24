using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    // 棋子享元抽像物件
    abstract class ChessFlyweight
    {
        protected string name; // 共享資料
        public ChessFlyweight(string name)
        {
            this.name = name;
        }
        public abstract void Display(int x, int y);
    }
}
