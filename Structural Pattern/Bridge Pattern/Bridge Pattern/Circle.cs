using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    // "圓形"類別 (抽象物件)
    class Circle : Shape
    {
        public Circle(DrawImplementor drawImplementor)
            : base(drawImplementor)
        {
        }

        public override void Draw()
        {
            drawImplementor.DrawCircle(); // 讓實作物件畫圖形
        }
    }
}
