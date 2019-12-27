using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    // 等級 20~50
    public class ConcreteState050 : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level < 50)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "老手");
            }
            else
            {
                user.setStateContext(new ConcreteState090());
                user.stateWork();
            }
        }
    }
}
