using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    class Program
    {
        //享元模式(Flyweight Pattern)

        //說明：
        //物件之間，若有共同的部分可以共享，則將可共用的部分獨立為共享物件，
        //不能共享的部份外部化，使用時再將外部化的部分傳給共享物件。
        //這樣做的優點是減少記憶體使用量。缺點是程式邏輯可能變得較複雜。

        //實現重點在於，區分共享資料和不可以共享的資料。共享資料做成共享物件，不可共享資料則使用時再傳給共享物件。
        //實例化共享物件時，則由享元工廠把關，判斷目前始否已經實例化過該共享物件，若有則直接回傳現存的共享物件。
        static void Main(string[] args)
        {
            ChessFlyweightFactory f = new ChessFlyweightFactory();

            ChessFlyweight a1 = f.GetChessFlyweight("黑棋"); // 取得黑棋共享物件
            a1.Display(1, 1); // 提供座標資料(非共享資料)
            ChessFlyweight a2 = f.GetChessFlyweight("黑棋"); // 取得黑棋共享物件
            a2.Display(1, 2); // 提供座標資料(非共享資料)
            ChessFlyweight a3 = f.GetChessFlyweight("黑棋"); // 取得黑棋共享物件
            a3.Display(1, 3); // 提供座標資料(非共享資料)
            ChessFlyweight b1 = f.GetChessFlyweight("白棋"); // 取得白棋共享物件
            b1.Display(2, 1); // 提供座標資料(非共享資料)
            ChessFlyweight b2 = f.GetChessFlyweight("白棋"); // 取得白棋共享物件
            b1.Display(2, 2); // 提供座標資料(非共享資料)
            ChessFlyweight b3 = f.GetChessFlyweight("白棋"); // 取得白棋共享物件
            b1.Display(2, 3); // 提供座標資料(非共享資料)

            Console.WriteLine("ChessFlyweight物件數量：{0}", f.GetChessFlyweightCount());

            Console.Read();
        }
    }
}
