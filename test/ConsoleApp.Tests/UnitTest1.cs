using System;
using Xunit;

namespace ConsoleApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(30, Program.Add(10, 20));
        }
    }
}
