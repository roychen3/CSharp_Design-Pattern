﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    // 地支解譯器
    class ExpressionB : Expression
    {
        public override void Excute(int num)
        {
            string res = "";
            switch (num)
            {
                case 1:
                    res = "子";
                    break;
                case 2:
                    res = "丑";
                    break;
                case 3:
                    res = "寅";
                    break;
                case 4:
                    res = "卯";
                    break;
                case 5:
                    res = "辰";
                    break;
                case 6:
                    res = "巳";
                    break;
                case 7:
                    res = "午";
                    break;
                case 8:
                    res = "未";
                    break;
                case 9:
                    res = "申";
                    break;
                case 10:
                    res = "酉";
                    break;
                case 11:
                    res = "戌";
                    break;
                case 12:
                    res = "亥";
                    break;
            }

            Console.Write(res);
        }
    }
}
