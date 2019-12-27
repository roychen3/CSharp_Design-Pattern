using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    // 第三種算法,滿 200 打 6 折
    class ConcreteStrategyC : Strategy
    {
        public void Execute(int money)
        {
            double res = (money >= 200) ? money * 0.6 : money;
            Console.WriteLine("原價 {0}, 滿200打6折 = {1}", money, res);
        }
    }
}
