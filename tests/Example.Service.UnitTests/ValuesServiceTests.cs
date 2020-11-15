using System;
using Example.Service.Services;
using Xunit;

namespace Example.Service.UnitTests
{
    public class ValuesServiceTests
    {
        [Fact]
        public void Should_Return_A_List_Of_Values()
        {
            // arrange
            var target = new ValuesService();
            // act
            var values = target.GetValues();
            // assert
            Assert.Equal(new[] { "value1", "value2" }, values);
        }
    }
}
