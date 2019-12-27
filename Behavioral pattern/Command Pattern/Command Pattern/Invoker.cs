using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    // 用來發出命令的類別
    class Invoker
    {
        private IList<Command> cmds = new List<Command>();

        public void SetCommand(Command command)
        {
            cmds.Add(command);
        }

        public void Run()
        {
            foreach (Command command in cmds)
            {
                command.Execute();
            }
        }

    }
}
