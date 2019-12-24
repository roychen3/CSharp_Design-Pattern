using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    // 回傳 A 品牌，實做的物件
    class Factory_A : AbstractFactory
    {
        public ToyCar CreateToyCar()
        {
            return new ToyCar_A();
        }

        public ToyDog CreateToyDog()
        {
            return new ToyDog_A();
        }
    }
}
