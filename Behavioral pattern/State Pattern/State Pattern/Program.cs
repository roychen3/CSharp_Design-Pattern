using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    class Program
    {
        //狀態模式(State Pattern)

        //說明：
        //一物件有多個狀態，在不同狀態下有不同的行為。
        //一般可能會用多個 if else 來處理這些分支行為。
        //若使用狀態模式，則是將這些分支行為，提取出來，放到另外的 class 處理。
        //也就是將 if else 拆開，改寫成一個分支一個 class。

        //這樣做的優點是，複雜的 if else 分支，維護可能較麻煩。
        //用狀態模式，修改或新增分支時，則只需要修改相關的幾個分支類別即可

        //實現重點在於，將每個 if else 改寫成多個單獨的分支類別。
        //若符合條件的不是某個分支類別，則繼續將流程丟給下一個分支類別處理。
        static void Main(string[] args)
        {
            Player user = new Player();
            user.level = 1; // 玩家等級
            user.stateWork(); // 玩家狀態處理
            user.level = 20;
            user.stateWork();
            user.level = 62;
            user.stateWork();
            user.level = 93;
            user.stateWork();

            Console.ReadLine();
        }
    }
}
