using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    // 第2種畫圓形的類別 (實作物件))
    class DrawCircle_B : DrawImplementor
    {
        public void DrawCircle()
        {
            Console.WriteLine("第 2 種畫圓形方法");
        }
    }
}
