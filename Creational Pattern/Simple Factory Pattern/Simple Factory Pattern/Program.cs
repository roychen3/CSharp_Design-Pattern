using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory_Pattern
{
    class Program
    {
        //簡單工廠模式(Simple Factory Pattern)
        
        //說明：
        //使用 class 的靜態方法，依不同條件，取得不同物件，並用取得的物件，做類似的事情。
        //缺點是要新增不同條件時，須修改到類別的靜態方法。

        //實現重點在於，將不同條件給靜態方法後(ToyFactory.CreateToy)，靜態方法能回傳同類型的物件。
        static void Main(string[] args)
        {
            Toy aa;
            aa = ToyFactory.CreateToy("car");
            aa.MakeToy();//製造了 玩具車

            aa = ToyFactory.CreateToy("dog");
            aa.MakeToy();//製造了 玩具狗

            Console.ReadLine();
        }
    }
}
