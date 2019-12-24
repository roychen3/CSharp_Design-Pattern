using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    // 棋子享元工廠，回傳棋子物件
    class ChessFlyweightFactory
    {
        private Hashtable chessFlyweight = new Hashtable();


        public ChessFlyweight GetChessFlyweight(string key)
        {
            if (!chessFlyweight.ContainsKey(key))
            {
                chessFlyweight.Add(key, new ConcreteChessFlyweight(key));
            }
            return (ChessFlyweight)chessFlyweight[key];
        }

        // 取得目前棋子物件數量
        public int GetChessFlyweightCount()
        {
            return chessFlyweight.Count;
        }
    }
}
