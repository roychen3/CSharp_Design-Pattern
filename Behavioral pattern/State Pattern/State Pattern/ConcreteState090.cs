using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    // 等級 50~90
    public class ConcreteState090 : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level < 90)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "高手");
            }
            else
            {
                user.setStateContext(new ConcreteStateMAX());
                user.stateWork();
            }
        }
    }
}
