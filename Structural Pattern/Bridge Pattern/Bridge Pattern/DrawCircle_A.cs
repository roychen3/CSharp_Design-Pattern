using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    // 第1種畫圓形的類別 (實作物件))
    class DrawCircle_A : DrawImplementor
    {
        public void DrawCircle()
        {
            Console.WriteLine("第 1 種畫圓形方法");
        }
    }
}
