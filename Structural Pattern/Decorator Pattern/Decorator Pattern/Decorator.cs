using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // 裝飾功能抽像類別，繼承「元件」抽像類別
    abstract class Decorator : Component
    {
        protected Component component;

        // 設定玩家(也可理解成設定Component)
        public void SetPlayer(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (this.component != null)
            {
                this.component.Operation();
            }
        }
    }
}
