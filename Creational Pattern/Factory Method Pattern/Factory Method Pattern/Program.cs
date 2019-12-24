using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    class Program
    {
        //工廠方法模式(Factory Method Pattern)

        //說明：
        //為避免了簡單工廠模式，對工廠類靜態方法的修改(對修改應該是封閉的)。
        //實作方式，將簡單工廠的工廠類靜態方法，再拆成不同的小子類。

        //實現重點在於，每個小工廠都有一個 CreateToy() 方法，能回傳同類型實際生產的物件。
        static void Main(string[] args)
        {
            // 工廠方法模式寫法
            ToyFactory xx;
            Toy aa;

            xx = new ToyCarFactory();
            aa = xx.CreateToy();
            aa.MakeToy();//製造了 玩具車

            xx = new ToyDogFactory();
            aa = xx.CreateToy();
            aa.MakeToy();//製造了 玩具車

            Console.ReadLine();
        }
    }
}
