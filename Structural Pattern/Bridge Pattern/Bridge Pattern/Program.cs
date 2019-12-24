using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class Program
    {
        //橋接模式(Bridge Pattern)

        //說明：
        //將一個物件的具體行為(實作)抽出來，成為一個獨立的物件。
        //也就是原本的一個物件，變成兩個物件：「抽像物件」+「實作物件」。
        //優點是抽像物件與實作物件可以解耦合，各自獨立變化。

        //實現重點在於，畫圖的實作物件，是分離出來，再另外指定的。
        static void Main(string[] args)
        {
            // 新增兩個圓形物件，分別指定不同畫圖物件
            Circle a = new Circle(new DrawCircle_A());
            Circle b = new Circle(new DrawCircle_B());

            // 分別畫出圓形
            a.Draw();
            b.Draw();

            Console.Read();
        }
    }
}
