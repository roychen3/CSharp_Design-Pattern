using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class Program
    {
        //解釋器模式(Interpreter Pattern)

        //說明：
        //用來解釋、直譯一種語言的方法。

        //實現重點在於，將待解釋的字串交給合適的解譯器處理。
        static void Main(string[] args)
        {
            // 待解譯文字
            Context context = new Context();
            context.Text = "b2002 a2002 b2013 a2013";

            // 解譯器
            Expression expression = null;

            while (context.Text.Length > 0)
            {
                switch (context.Text.Substring(0, 1))
                {
                    case "a":
                        expression = new ExpressionA(); // 生肖
                        break;
                    case "b":
                        expression = new ExpressionB(); // 地支
                        break;
                }

                expression.Interpret(context);
            }

            Console.Read();
        }
    }
}
