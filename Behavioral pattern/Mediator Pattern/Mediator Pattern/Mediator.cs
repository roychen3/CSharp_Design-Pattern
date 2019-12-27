using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    // 中介者抽像類別
    abstract class Mediator
    {
        protected MedicColleague medic; // 醫護兵
        protected InfantryColleague infantry; // 步兵

        // 設定醫護兵
        public MedicColleague Medic
        {
            set { medic = value; }
        }

        // 設定步兵
        public InfantryColleague Infantry
        {
            set { infantry = value; }
        }
        public abstract void Work(string msgType, string msgCon, Colleague colleague);
    }
}
