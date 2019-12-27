using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    // 向前走一步的命令
    class GoAheadCommand : Command
    {
        public GoAheadCommand(ReceiverRobot robot)
            : base(robot)
        {
        }

        public override void Execute()
        {
            robot.GoAhead();
        }
    }
}
