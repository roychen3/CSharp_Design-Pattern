using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    // 抽象工廠
    interface AbstractFactory
    {
        ToyCar CreateToyCar();
        ToyDog CreateToyDog();
    }
}
