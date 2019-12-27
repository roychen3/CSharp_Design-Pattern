using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    // 解譯器抽像類別
    abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Text.Length > 0)
            {
                // 取得前面第一個分隔字串
                int spacePos = context.Text.IndexOf(" ");
                string word = "";
                if (-1 != spacePos)
                {
                    word = context.Text.Substring(0, spacePos);
                    // 將剩下的字串重新設定到未解譯的資料
                    context.Text = context.Text.Substring(spacePos + 1);

                }
                else
                {
                    // 最後一個字串
                    word = context.Text;
                    context.Text = "";
                }

                // 單字解譯
                int num = (Convert.ToInt32(word.Substring(1)) + 9) % 12;
                if (0 == num)
                {
                    num = 12;
                }
                Excute(num);
            }
        }

        public abstract void Excute(int num);
    }
}
