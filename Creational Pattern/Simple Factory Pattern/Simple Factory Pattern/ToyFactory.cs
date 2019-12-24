using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory_Pattern
{
    class ToyFactory
    {
        public static Toy CreateToy(String cc)
        {
            Toy obj = null;
            switch (cc)
            {
                case "car":
                    obj = new ToyCar();
                    break;
                case "dog":
                    obj = new ToyDog();
                    break;
                default:
                    throw new Exception("沒有這個類別");

            }
            return obj;
        }
    }
}
