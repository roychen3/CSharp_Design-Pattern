using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class Program
    {
        //觀察者模式(發佈/訂閱模式) (Observer Pattern)

        //說明：
        //兩種類型的物件，「通知者」和「觀察者」。
        //訂閱：「通知者」可增減訂閱列表中的「觀察者」
        //發佈：當有監聽的事件發生時，「通知者」可從訂閱列表中，將事件通知「觀察者」，「觀察者」則會對此事件做相對應的動作。

        //功用：解除耦合，讓耦合的雙方依賴抽像(接口)，而不依賴具體。

        //實現重點在於，「觀察者」要實做同一個方法 Update()，如此事件發生時，「通知者」才知道訂閱列表中的「觀察者」都執行 Update()。
        //(備註：C# 如果用 delegate 委派的方式來做，Update方法名稱就可以也不一樣了)
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserverA(s, "酸民甲"));
            s.Attach(new ConcreteObserverA(s, "酸民乙"));
            s.Attach(new ConcreteObserverB(s, "路人丙"));
            s.Attach(new ConcreteObserverB(s, "路人丁"));

            s.SubjectState = "ABC";
            s.Notify();

            Console.WriteLine("-------------------");

            s.SubjectState = "DEF";
            s.Notify();

            Console.Read();
        }
    }
}
