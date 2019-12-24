using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    class ToyCar : Toy
    {
        public override void MakeToy()
        {
            Console.WriteLine("製造了 玩具車");
        }
    }
}
