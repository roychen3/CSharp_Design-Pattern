using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    // 向左轉的命令
    class TurnLeftCommand : Command
    {
        public TurnLeftCommand(ReceiverRobot robot)
            : base(robot)
        {
        }

        public override void Execute()
        {
            robot.TurnLeft();
        }
    }
}
