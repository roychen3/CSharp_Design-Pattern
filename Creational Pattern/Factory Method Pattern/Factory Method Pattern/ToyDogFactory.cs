﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    class ToyDogFactory : ToyFactory
    {
        public Toy CreateToy()
        {
            return new ToyDog();
        }
    }
}
