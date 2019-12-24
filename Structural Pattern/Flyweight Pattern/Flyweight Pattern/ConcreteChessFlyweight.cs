using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    // 棋子享元(共享物件)
    class ConcreteChessFlyweight : ChessFlyweight
    {
        public ConcreteChessFlyweight(string name)
            : base(name)
        {
        }

        // X、Y座標，非共享資料
        public override void Display(int x, int y)
        {
            Console.WriteLine("{0}({1},{2})", this.name, x, y);
        }
    }
}
