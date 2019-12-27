using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    // 中介者
    class ConcreteMediator : Mediator
    {
        // 中介者處理接收到的訊息
        public override void Work(string msgType, string msgCon, Colleague colleague)
        {
            Console.WriteLine("中介者 接收到 {0} 訊息：{1} => 訊息處理", colleague.Name, msgCon);
            switch (msgType)
            {
                case "hurt":
                    this.medic.Action(msgCon, colleague);
                    break;
                case "attack":
                    this.infantry.Action(msgCon, colleague);
                    break;
                case "normal":
                    if (colleague != this.medic) this.medic.Receive(msgCon, colleague);
                    if (colleague != this.infantry) this.infantry.Receive(msgCon, colleague);
                    break;
            }
        }
    }
}
