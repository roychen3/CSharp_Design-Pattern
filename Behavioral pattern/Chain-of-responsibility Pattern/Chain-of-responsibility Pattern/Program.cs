using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_Pattern
{
    class Program
    {
        //責任鏈模式(Chain-of-responsibility Pattern)

        //說明：
        //有幾個物件都能處理某種請求，但處理的能範圍(權限)不同，
        //當這個物件沒有處理的權限時，能夠將這個請求，傳遞給下一個物件繼續處理。

        //實現重點在於，負責處理的物件，要能設定當自己沒辦法處理時，要將請求丟給誰。
        //並判斷，遇到不能處理的請求時，繼續將請求傳遞給下一個負責處理的物件。
        static void Main(string[] args)
        {
            // 管理者初始化
            Manager a1 = new Manager("阿福"); // 經理
            Director a2 = new Director("技安"); // 協理
            GeneralManager a3 = new GeneralManager("宜靜"); // 總經理
            a1.SetUpManager(a2); // 設定經理的上級為協理
            a2.SetUpManager(a3); // 設定協理的上級為總經理

            // 假單初始化
            LeaveRequest leaveRequest = new LeaveRequest(); // 假單
            leaveRequest.Name = "大雄"; // 員工姓名

            leaveRequest.DayNum = 1; // 請假天數
            a1.RequestPersonalLeave(leaveRequest);// 送出1天的假單

            leaveRequest.DayNum = 3; // 請假天數
            a1.RequestPersonalLeave(leaveRequest);// 送出3天的假單

            leaveRequest.DayNum = 7; // 請假天數
            a1.RequestPersonalLeave(leaveRequest);// 送出7天的假單

            leaveRequest.DayNum = 10; // 請假天數
            a1.RequestPersonalLeave(leaveRequest);// 送出10天的假單

            Console.Read();
        }
    }
}
