using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // 裝飾功能B (護盾裝備)
    class Decorator_B : Decorator
    {
        public override void Operation()
        {
            base.Operation(); // 執行原本玩家的功能
            Console.WriteLine("裝備了 護盾，防禦力+5"); // 執行新功能
        }
    }
}
