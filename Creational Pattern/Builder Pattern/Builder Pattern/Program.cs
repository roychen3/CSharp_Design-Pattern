using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    class Program
    {
        //建造者模式(生成器模式) (Builder Pattern)

        //說明：
        //將某種類產品，生產步驟整理出來。
        //所有要生產這類產品的 class，均要實現這些標準化步驟。
        //另外，為避免實際生產時，遺漏某步驟，統一由一個 class，執行一系列的生產步驟。

        //實現重點在於，大杯珍奶、小杯紅茶物件，都能傳給 Director 操作。
        static void Main(string[] args)
        {
            Director aa = new Director();
            Bulider bb = new LargeMilkTeaWithTapiocaBalls();
            aa.setBulider(bb);
            aa.create();

            Console.WriteLine("----------");

            bb = new SmallBlackTea();
            aa.setBulider(bb);
            aa.create();

            Console.ReadLine();
        }
    }
}
