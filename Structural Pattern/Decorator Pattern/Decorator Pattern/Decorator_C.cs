using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // 裝飾功能C (靴子裝備)
    class Decorator_C : Decorator
    {
        public override void Operation()
        {
            base.Operation(); // 執行原本玩家的功能
            Console.WriteLine("裝備了 靴子，速度+2"); // 執行新功能
        }
    }
}
