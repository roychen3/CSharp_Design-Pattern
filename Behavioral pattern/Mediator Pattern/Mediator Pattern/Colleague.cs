using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    // 同事抽象類別
    abstract class Colleague
    {
        protected string name; // 姓名

        protected Mediator mediator; // 中介者

        // 設定姓名、中介者
        public Colleague(string name, Mediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 發送訊息給中介者
        public void Send(string msgType, string msgCon)
        {
            mediator.Work(msgType, msgCon, this);
        }

        // 接收一般訊息
        public void Receive(string msgCon, Colleague colleague)
        {
            Console.WriteLine("{0} 接收到 {1} 訊息：{2}", this.name, colleague.Name, msgCon);
        }
    }
}
