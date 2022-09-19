﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitX.KXP.Tool
{
    internal static class ConsoleHelper
    {
        internal static void WriteSeparater(char sep = '-')
        {
            Console.WriteLine(new StringBuilder().Append(sep, Console.WindowWidth).ToString());
        }

        internal static void DoInAnotherColor(ConsoleColor cc = ConsoleColor.White, Action? action = null)
        {
            ConsoleColor nowColor = Console.ForegroundColor;
            Console.ForegroundColor = cc;
            action?.Invoke();
            Console.ForegroundColor = nowColor;
        }
    }
}