using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    // 醫護兵
    class MedicColleague : Colleague
    {
        public MedicColleague(string name, Mediator mediator)
            : base(name, mediator)
        {
            mediator.Medic = this;
        }

        // 醫療行動
        public void Action(string msgCon, Colleague colleague)
        {
            Console.WriteLine("{0} 接收到 {1} 訊息：{2}。前往救護中", this.name, colleague.Name, msgCon);
        }
    }
}
