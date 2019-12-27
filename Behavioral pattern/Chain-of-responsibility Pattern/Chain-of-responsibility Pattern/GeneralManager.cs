using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_Pattern
{
    // 總經理
    class GeneralManager : ManagerHandler
    {
        public GeneralManager(string name) : base(name) { }

        public override void RequestPersonalLeave(LeaveRequest leaveRequest)
        {
            if (leaveRequest.DayNum <= 7)
            {
                // 7天以內，總經理批准
                Console.WriteLine("總經理 {0} 已批准 {1}{2}天的事假", this.name, leaveRequest.Name, leaveRequest.DayNum);
            }
            else
            {
                // 超過7天以上，再深入了解原因
                Console.WriteLine("總經理 {0} 要再了解 {1}{2}天的事假原因", this.name, leaveRequest.Name, leaveRequest.DayNum);
            }
        }
    }
}
