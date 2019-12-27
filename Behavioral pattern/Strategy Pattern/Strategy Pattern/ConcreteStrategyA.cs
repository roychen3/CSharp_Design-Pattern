using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    // 第一種算法,打 8 折
    class ConcreteStrategyA : Strategy
    {
        public void Execute(int money)
        {
            double res = money * 0.8;
            Console.WriteLine("原價 {0}, 打8折 = {1}", money, res);
        }
    }
}
