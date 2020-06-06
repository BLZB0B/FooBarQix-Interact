using System;
using System.Collections;
using FooBarQixKataInteract;
using NUnit.Framework;

namespace FooBarQixKataInteractTests
{
    [TestFixture]
    public class CalculateTests
    {
        /*
        If the number is divisible by 3, write “Foo” instead of the number
        If the number is divisible by 5, add “Bar”
        If the number is divisible by 7, add “Qix”
        For each digit 3, 5, 7, add “Foo”, “Bar”, “Qix” in the digits order.
        */

        private FooBarCalculator _fooBarCalculator;

        [SetUp]
        public void Setup()
        {
            _fooBarCalculator = new FooBarCalculator();
        }

        public class MyDataClass
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData("1").Returns("1");
                    yield return new TestCaseData("2").Returns("2");
                    yield return new TestCaseData("3").Returns("FooFoo");
                    yield return new TestCaseData("4").Returns("4");
                    yield return new TestCaseData("5").Returns("BarBar");
                    yield return new TestCaseData("6").Returns("Foo");
                    yield return new TestCaseData("7").Returns("QixQix");
                    yield return new TestCaseData("8").Returns("8");
                    yield return new TestCaseData("9").Returns("Foo");
                    yield return new TestCaseData("10").Returns("Bar*");
                    yield return new TestCaseData("13").Returns("Foo");
                    yield return new TestCaseData("15").Returns("FooBarBar");
                    yield return new TestCaseData("21").Returns("FooQix");
                    yield return new TestCaseData("33").Returns("FooFooFoo");
                    yield return new TestCaseData("51").Returns("FooBar");
                    yield return new TestCaseData("53").Returns("BarFoo");
                    yield return new TestCaseData("101").Returns("1*1");
                    yield return new TestCaseData("303").Returns("FooFoo*Foo");
                    yield return new TestCaseData("105").Returns("FooBarQix*Bar");
                    yield return new TestCaseData("10101").Returns("FooQix**");
                }
            }
        }

        [TestCaseSource(typeof(MyDataClass), "TestCases")]
        public string Tests(string input)
        {
            return _fooBarCalculator.Compute(input);

        }

    }
}
