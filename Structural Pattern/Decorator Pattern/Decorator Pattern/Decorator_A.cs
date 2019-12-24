using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // 裝飾功能A (寶劍裝備)
    class Decorator_A : Decorator
    {
        public override void Operation()
        {
            base.Operation(); // 執行原本玩家的功能
            Console.WriteLine("裝備了 寶劍，攻擊力+10"); // 執行新功能
        }
    }
}
