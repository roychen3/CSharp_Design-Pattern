using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    class Program
    {
        //訪問者模式(Visitor Pattern)

        //說明：
        //當一個「物件結構」中的「元素」幾乎不會異動，但這些「元素的行為」常會增減，則適合用訪問者模式。
        //訪問者模式是將「元素的行為」，提取出來，每一種行為做成一個 「Visitor(訪問者) 物件」，
        //每一個 「Visitor(訪問者) 物件」，都能依據不同的「元素」，對應到不同的行為結果。

        //實現的重點在於，物件往返傳了兩次，
        //第一次是「Visitor物件」經由「結構物件」傳給「元素物件」
        //第二次是「元素物件」將自己傳給「Visitor物件」，以便「Visitor物件」依不同的「元素物件」執行不同的方法。
        static void Main(string[] args)
        {
            // 物件結構
            ObjectStructure o = new ObjectStructure();
            // 誠實人元素物件
            HonestManElement honestMan = new HonestManElement();
            // 說謊人元素物件
            LieManElement lieMan = new LieManElement();

            // 將誠實人、說謊人元素物件放進物件結構
            o.Attach(honestMan);
            o.Attach(lieMan);


            // 數學問題訪問者
            MathVisitor mathVisitor = new MathVisitor();
            Console.WriteLine("[數學問題]");
            o.Display(mathVisitor); // 輸出結果

            // 物理問題訪問者
            PhysicsVisitor physicsVisitor = new PhysicsVisitor();
            Console.WriteLine("[物理問題]");
            o.Display(physicsVisitor); // 輸出結果

            Console.Read();
        }
    }
}
