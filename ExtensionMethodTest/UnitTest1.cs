using Xunit;
using System;
using ExtensionMethodDemo;

namespace ExtensionMethodTest
{
    public class UnitTest1
    {
        [Fact]
        public void ToCurrency_ValidInput()
        {
            string currency= "123" ;
            Assert.Equal("$123", ExtMethodClass.ToCurrency(currency));
        }
        [Theory]
        [InlineData("123abc")]
        [InlineData("abcd9010")]
        public void ToCurrency_InValidInput(string currency)
        {
            string excep = "Entered String does not contain numbers";
            var exp = Assert.Throws<ArgumentException>(() => ExtMethodClass.ToCurrency(currency));
            Assert.Equal( excep, exp.Message);
        }
        [Fact]
        public void ToCurrency_WhenEmptyStringGiven()
        {
            string currency = "";
            Assert.Equal("$", ExtMethodClass.ToCurrency(currency));
        }
    }
}