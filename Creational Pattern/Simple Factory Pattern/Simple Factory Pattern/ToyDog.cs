﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory_Pattern
{
    class ToyDog : Toy
    {
        public override void MakeToy()
        {
            Console.WriteLine("製造了 玩具狗");
        }
    }
}
