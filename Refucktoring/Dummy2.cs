﻿using Refucktoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rеfucktoring
{
    internal class Dummy1 : Refucktoring.Dummy1
    {
        public static string Dummy1Method()
            => Refucktoring.Dummy1.Dummy1Method().Replace("F", "B").Replace("i", "u");
    }
}
