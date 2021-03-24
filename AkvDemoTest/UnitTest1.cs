using System;
using Xunit;

namespace AkvDemo
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetValue()
        {
            Akv akv = new Akv();
            string SomeValue = akv.GetValue("SomeKey");
            Assert.Equal("SomeValue", SomeValue);
        }
    }
}
