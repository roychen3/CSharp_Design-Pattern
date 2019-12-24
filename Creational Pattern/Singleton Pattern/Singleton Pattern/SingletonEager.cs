using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class SingletonEager
    {
        // 設為 static，載入時，即 new 一個實例
        private static readonly SingletonEager instance = new SingletonEager();

        public int test = 1;

        // 設為 private，外界不能 new
        private SingletonEager()
        {
        }

        // 使用靜態方法取得實例，因為載入時就 new 一個實例，所以不用考慮多執行緒的問題
        public static SingletonEager GetInstance()
        {
            return instance;
        }
    }
}
