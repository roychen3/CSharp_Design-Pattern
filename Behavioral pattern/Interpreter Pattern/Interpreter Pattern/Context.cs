using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    // 存放待解譯資料
    class Context
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
