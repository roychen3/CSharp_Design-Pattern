using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    class Program
    {
        //中介者模式(Mediator Pattern)

        //說明：
        //當物件和物件之間或有錯綜複雜的交互作用，可將這些關係交由另一物件(中介者)來處理，
        //以減少這些物件間的耦合。

        //實現重點在於，同事物件(醫護兵物件、步兵物件)發出訊息時，其實是丟給中介者物件，再由中介者物件負責訊息要再傳遞給誰。
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator(); // 中介者

            MedicColleague medic = new MedicColleague("小護士", mediator); // 醫護兵
            InfantryColleague infantry = new InfantryColleague("小小強", mediator); // 步兵

            medic.Send("normal", "吹東風了");
            infantry.Send("normal", "左前方一隻小白兔走過去");
            medic.Send("attack", "遭受敵人攻擊");
            infantry.Send("hurt", "我中彈了");

            Console.Read();
        }
    }
}
