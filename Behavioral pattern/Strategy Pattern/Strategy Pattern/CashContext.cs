using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    // 用來維護策略物件的類別
    class CashContext
    {
        Strategy strategy; // 算法物件

        public CashContext(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ExecuteStrategy(int money)
        {
            this.strategy.Execute(money);
        }
    }
}
