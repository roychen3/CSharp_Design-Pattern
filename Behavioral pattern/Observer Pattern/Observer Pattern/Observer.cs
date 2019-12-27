using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    //觀察者的抽象類別
    abstract class Observer
    {
        public abstract void Update();
    }
}
