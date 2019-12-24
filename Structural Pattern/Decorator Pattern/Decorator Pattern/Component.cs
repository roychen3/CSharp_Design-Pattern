using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // 「元件」抽像類別，定義了「被裝飾者」和「裝飾功能」要實做的方法
    abstract class Component
    {
        public abstract void Operation();
    }
}
