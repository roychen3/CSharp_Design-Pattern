using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    //大杯奶茶生產過程，實作 Bulider 介面
    class LargeMilkTeaWithTapiocaBalls : Bulider
    {
        public void TakeTheCup()
        {
            Console.WriteLine("拿大杯子");
        }
        public void PourDrinks()
        {
            Console.WriteLine("裝珍珠、裝奶茶");
        }

        public void AddCover()
        {
            Console.WriteLine("拿大蓋子加蓋");
        }

        public void TakeAStraw()
        {
            Console.WriteLine("拿粗吸管");
        }
    }
}
