using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    // 玩家類別，有一個等級的屬性
    public class Player
    {
        public int level = 1; // 等級

        /* 狀態處理，一般用 if else 的寫法
        public void stateWork()
        {
            if (level >= 1 && level < 20)
            {
                Console.WriteLine("等級 {0} ({1})", level, "新手");
            }
            else if (level >= 20 && level < 50)
            {
                Console.WriteLine("等級 {0} ({1})", level, "老手");
            }
            else if (level >= 50 && level < 90)
            {
                Console.WriteLine("等級 {0} ({1})", level, "高手");
            }
            else if (level >= 90)
            {
                Console.WriteLine("等級 {0} ({1})", level, "神");
            }
        }
        */

        // 將狀態處理改為以下寫法 (狀態模式)
        private StateContext state;

        public Player()
        {
            // 初始化狀態處理的物件
            setStateContext(new ConcreteState001());
        }

        // 設定狀態處理的物件
        public void setStateContext(StateContext s)
        {
            state = s;
        }

        // 狀態處理，轉交由 StateContext 物件處理
        public void stateWork()
        {
            state.stateWork(this);
        }
    }
}
