using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Program
    {
        //命令模式(Command Pattern)，以下程式碼以 C# 為例

        //說明：
        //命令包含發出命令和執行命令。
        //命令模式，則是將這個過程拆成三個物件，
        //發出命令的物件(Invoker)、命令的物件(command)、執行命令的物件(receiver)
        //由 Invoker 物件，來建造要執行的命令。
        //如此要擴充功能時，例如增加命令重覆執行、取消命令...等，也變得較單純。

        //實現重點在於，分成發命令物件、命令物件、執行命令的物件。
        //發命令物件：可用來新增要執行命令。
        //命令物件：可指定執行此命令的物件。
        //執行命令的物件：真正執行此命令的物件。
        static void Main(string[] args)
        {
            // 初始化各個物件
            Invoker invoker = new Invoker(); // 發命令物件

            ReceiverRobot robot = new ReceiverRobot(); // 執行命令物件

            GoAheadCommand cmd_go_ahead = new GoAheadCommand(robot); // 向前走指令
            TurnLeftCommand cmd_turn_left = new TurnLeftCommand(robot); // 左轉指令
            TurnRightCommand cmd_turn_right = new TurnRightCommand(robot); // 右轉指令

            // 設定要執行的命令
            invoker.SetCommand(cmd_go_ahead);
            invoker.SetCommand(cmd_go_ahead);
            invoker.SetCommand(cmd_turn_left);
            invoker.SetCommand(cmd_go_ahead);
            invoker.SetCommand(cmd_turn_right);

            // 開始執行命令
            invoker.Run();

            Console.Read();
        }
    }
}
