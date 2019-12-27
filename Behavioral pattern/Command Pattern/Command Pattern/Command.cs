using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    // 命令的抽像類別，用來衍生各種命令，建構時，須設定實際執行命令的物件
    abstract class Command
    {
        protected ReceiverRobot robot;

        // 設定實際執行命令的物件
        public Command(ReceiverRobot robot)
        {
            this.robot = robot;
        }

        // 用來呼叫執行命令的物件，開始執行命令
        abstract public void Execute();
    }
}
