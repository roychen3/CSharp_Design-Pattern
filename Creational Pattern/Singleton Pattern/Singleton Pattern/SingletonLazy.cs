﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class SingletonLazy
    {
        // 多執行緒，lock 使用
        private static readonly object thisLock = new object();

        // 將唯一實例設為 private static
        private static SingletonLazy instance;

        public int test = 1;

        // 設為 private，外界不能 new
        private SingletonLazy()
        {
        }

        // 外界只能使用靜態方法取得實例
        public static SingletonLazy GetInstance()
        {
            // 先判斷目前有沒有實例，沒有的話才開始 lock，
            // 此次的判斷，是避免在有實例的情況，也執行 lock ，影響效能
            if (null == instance)
            {
                // 避免多執行緒可能會產生兩個以上的實例，所以 lock
                lock (thisLock)
                {
                    // lock 後，再判斷一次目前有無實例
                    // 此次的判斷，是避免多執行緒，同時通過前一次的 null == instance 判斷
                    if (null == instance)
                    {
                        instance = new SingletonLazy();
                    }
                }
            }

            return instance;
        }
    }
}
