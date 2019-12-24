using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    //小杯紅茶生產過程，實作 Bulider 介面
    class SmallBlackTea : Bulider
    {
        public void TakeTheCup()
        {
            Console.WriteLine("拿小杯子");
        }
        public void PourDrinks()
        {
            Console.WriteLine("裝紅茶");
        }

        public void AddCover()
        {
            Console.WriteLine("拿小蓋子加蓋");
        }

        public void TakeAStraw()
        {
            Console.WriteLine("拿細吸管");
        }
    }
}
