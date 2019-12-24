using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    //B 品牌玩具狗
    class ToyDog_B : ToyDog
    {
        public override void MakeToyDog()
        {
            Console.WriteLine("B 品牌 製造的 玩具狗");
        }
    }
}
