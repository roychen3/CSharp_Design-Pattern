using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    // 第二種算法,打 7 折
    class ConcreteStrategyB : Strategy
    {
        public void Execute(int money)
        {
            double res = money * 0.7;
            Console.WriteLine("原價 {0}, 打7折 = {1}", money, res);
        }
    }
}
