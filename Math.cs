﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD06
{
    public static class Math
    {

        public static double Add(double a, double b) { return a + b; }
        public static double Subtract(double a, double b) {return a - b; }

        public static double Multiply(double a, double b) {return (a * b); }

        public static double Divide(double a, double b) { if (a == 0 || b == 0) return 0; return a / b; }
    }
}
