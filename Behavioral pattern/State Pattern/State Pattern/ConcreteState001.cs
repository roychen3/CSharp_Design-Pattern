using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    // 等級 1~20
    public class ConcreteState001 : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level < 20)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "新手");
            }
            else
            {
                user.setStateContext(new ConcreteState050());
                user.stateWork();
            }
        }
    }
}
