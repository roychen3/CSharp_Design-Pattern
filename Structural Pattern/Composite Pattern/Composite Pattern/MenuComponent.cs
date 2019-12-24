using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    // 選單元件抽像介面
    abstract class MenuComponent
    {
        protected string name;

        public MenuComponent(string name)
        {
            this.name = name;
        }

        // 顯示資料
        public abstract void Print(int depth);
    }
}
