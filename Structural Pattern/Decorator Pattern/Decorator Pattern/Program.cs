using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Program
    {
        //裝飾模式(Decorator Pattern)

        //說明：
        //在某一物件動態加上功能。
        //一層一層的將功能套上去，每一層執行的是不同的物件。

        //實現重點在於，
        //功能A、功能B、功能C 除了能接受玩家 player為處理對象，也能接受彼此為處理對象，才可以一層一層將功能疊加上去。
        //也就是「被裝飾者」和「裝飾功能」要繼承某一共同類別，並實做某一共同的方法，
        //我們將此共同類別抽出來當一個抽象類別，叫做 Component。
        static void Main(string[] args)
        {
            // 玩家
            Player player = new Player();

            // 裝飾功能A (寶劍裝備)
            Decorator_A A = new Decorator_A();
            A.SetPlayer(player); // 將"玩家"給功能A，增加寶劍裝備

            // 裝飾功能B (護盾裝備)
            Decorator_B B = new Decorator_B();
            B.SetPlayer(A); // 繼續給功能B，增加護盾裝備

            // 裝飾功能C (靴子裝備)
            Decorator_C C = new Decorator_C();
            C.SetPlayer(B); // 繼續給功能C，增加靴子裝備

            // 開始一層一層執行裝備東西
            C.Operation();

            Console.ReadLine();
        }
    }
}
