using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_Pattern
{
    // 經理
    class Manager : ManagerHandler
    {
        public Manager(string name) : base(name) { }

        public override void RequestPersonalLeave(LeaveRequest leaveRequest)
        {
            if (leaveRequest.DayNum <= 2)
            {
                // 2天以內，經理可以批准
                Console.WriteLine("經理 {0} 已批准 {1}{2}天的事假", this.name, leaveRequest.Name, leaveRequest.DayNum);
            }
            else
            {
                // 超過2天，轉呈上級
                if (null != upManager)
                {
                    upManager.RequestPersonalLeave(leaveRequest);
                }
            }
        }
    }
}
