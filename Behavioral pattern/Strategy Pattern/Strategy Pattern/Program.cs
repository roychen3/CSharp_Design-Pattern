using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        //策略模式(Strategy Pattern)

        //說明：
        //將不同的演算法，定義成一個家族，
        //這些演算法實現同樣的接口，且寫成個別的類別，所以彼此之間能夠互相替換。
        //優點是以後要增加新的演算法，只須額外新增一個類別，不須動到原本的類別。

        //實現重點在於，演算法要實現同樣的接口，才能讓 context 類別能用同樣的方式，操作不同的演算法。
        static void Main(string[] args)
        {
            CashContext cc;
            // 打8折的時候
            cc = new CashContext(new ConcreteStrategyA());
            cc.ExecuteStrategy(100);

            // 打7折的時候
            cc = new CashContext(new ConcreteStrategyB());
            cc.ExecuteStrategy(100);

            // 滿200打6折的時候
            cc = new CashContext(new ConcreteStrategyC());
            cc.ExecuteStrategy(200);

            Console.Read();
        }
    }
}
