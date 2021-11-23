using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Calc;

namespace CalcTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Тест проверки метода AddWithInc
        /// </summary>
        [Test]
        public void AddWithInc_2Plus3Inc1_Returned6()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 2;
            double arg2 = 3;
            double expected = 6;
            // act
            double result = calc.AddWithInc(arg1, arg2);
            // assert            
            NUnit.Framework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void Div_4Div2_Returned2()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 4;
            double arg2 = 2;
            double expected = 2;
            // act
            double result = calc.Div(arg1, arg2);
            // assert            
            NUnit.Framework.Assert.AreEqual(expected, result);
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException),
    "Oh my god, we can't divison on zero")]
        public void Div_4Div0_ZeroDivException()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 4;
            double arg2 = 0;
            // act
            double result = calc.Div(arg1, arg2);
            // assert            
        }
    }
}