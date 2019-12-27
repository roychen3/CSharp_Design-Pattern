using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_Pattern
{
    // 假單
    class LeaveRequest
    {
        // 姓名
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 天數
        private int dayNum;
        public int DayNum
        {
            get { return dayNum; }
            set { dayNum = value; }
        }
    }
}
