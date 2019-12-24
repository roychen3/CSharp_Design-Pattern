using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    // "形狀"的抽象類別
    abstract class Shape
    {
        protected DrawImplementor drawImplementor;

        protected Shape(DrawImplementor drawImplementor)
        {
            this.drawImplementor = drawImplementor;
        }

        public abstract void Draw();
    }
}
