using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    // 步兵
    class InfantryColleague : Colleague
    {
        public InfantryColleague(string name, Mediator mediator)
            : base(name, mediator)
        {
            mediator.Infantry = this;
        }

        // 攻擊行動
        public void Action(string msgCon, Colleague colleague)
        {
            Console.WriteLine("{0} 接收到 {1} 訊息：{2}。前往救助中", this.name, colleague.Name, msgCon);
        }
    }
}
