using System;
using Xunit;
using guessTheNumber;

namespace guessTheNumberTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Game number = new Game(55);
            Output result = number.Check(55);
            Output expected = new Output("true", true);
            expected.Message().Equals(result.Message());
        }
        [Fact]
        public void Test2()
        {
            Game number = new Game(55);
            Output result = number.Check(44);
            Output expected = new Output("greater", false);
            expected.Message().Equals(result.Message());
        }
        [Fact]
        public void Test3()
        {
            Game number = new Game(55);
            Output result = number.Check(66);
            Output expected = new Output("less", false);
            expected.Message().Equals(result.Message());
        }

    }
}
