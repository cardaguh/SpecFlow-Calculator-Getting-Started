using System;
using TechTalk.SpecFlow;
using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [Binding]
    public class CalculatorSteps2
    {
        private int result;
        private Example.Calculator calculator = new Example.Calculator();
       
    }
}
