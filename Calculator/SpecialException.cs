﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class SpecialException : Exception
    {
        public SpecialException() { }
        public SpecialException(string message) : base(message) { }
    }
}
