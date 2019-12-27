using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_Pattern
{
    // 協理
    class Director : ManagerHandler
    {
        public Director(string name) : base(name) { }

        public override void RequestPersonalLeave(LeaveRequest leaveRequest)
        {
            if (leaveRequest.DayNum <= 5)
            {
                // 5天以內，經理可以批准
                Console.WriteLine("協理 {0} 已批准 {1}{2}天的事假", this.name, leaveRequest.Name, leaveRequest.DayNum);
            }
            else
            {
                // 超過5天，轉呈上級
                if (null != upManager)
                {
                    upManager.RequestPersonalLeave(leaveRequest);
                }
            }
        }
    }
}
