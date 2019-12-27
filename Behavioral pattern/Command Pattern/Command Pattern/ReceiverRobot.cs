using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    // 實際執行命令的物件
    class ReceiverRobot
    {
        public void GoAhead()
        {
            Console.WriteLine("向前走一步");
        }

        public void TurnLeft()
        {
            Console.WriteLine("向左轉");
        }

        public void TurnRight()
        {
            Console.WriteLine("向右轉");
        }
    }
}
