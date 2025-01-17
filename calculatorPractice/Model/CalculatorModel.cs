﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorPractice.Model
{
    public class CalculatorModel
    {
        public double Add(double a, double b) => a+ b;
        public double Substract(double a, double b) => a-b;
        public double Multiply(double a, double b) => a*b;
        public double Divide( double a, double b) => b!=0 ? a/b: throw new DivideByZeroException();
    }
}
