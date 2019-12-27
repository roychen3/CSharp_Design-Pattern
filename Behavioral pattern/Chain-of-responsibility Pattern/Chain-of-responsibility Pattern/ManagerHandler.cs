using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_Pattern
{
    // 管理者處理事假申請的抽象類別
    abstract class ManagerHandler
    {
        protected string name;
        protected ManagerHandler upManager; // 上一級的管理者

        public ManagerHandler(string name)
        {
            this.name = name;
        }

        // 設定上一級的管理者
        public void SetUpManager(ManagerHandler upManager)
        {
            this.upManager = upManager;
        }

        // 事假處理
        abstract public void RequestPersonalLeave(LeaveRequest leaveRequest);
    }
}
