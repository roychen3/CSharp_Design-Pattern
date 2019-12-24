using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    //B 品牌玩具車
    class ToyCar_B : ToyCar
    {
        public override void MakeToyCar()
        {
            Console.WriteLine("B 品牌 製造的 玩具車");
        }
    }
}
