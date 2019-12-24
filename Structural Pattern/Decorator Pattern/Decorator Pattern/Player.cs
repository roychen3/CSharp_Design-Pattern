using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // 玩家(被裝飾者)，實做元件抽像介面
    class Player : Component
    {
        public override void Operation()
        {
            Console.WriteLine("玩家的裝備：");
        }
    }
}
