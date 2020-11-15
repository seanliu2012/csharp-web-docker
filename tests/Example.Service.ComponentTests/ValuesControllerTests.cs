using System.Net.Http;
using System;
using Xunit;
using System.Threading.Tasks;

namespace Example.Service.ComponentTests
{
    public class ValuesControllerTests : IClassFixture<ComponentTestFixture>
    {
        private ComponentTestConfig _testConfig;

        public ValuesControllerTests(ComponentTestFixture fixture)
        {
            _testConfig = fixture.TestConfig;
        }

        [Fact]
        public async Task Should_Return_A_List_Of_Values_OnGetRequestAsync()
        {
            // arrange
            var httpClient = new HttpClient { BaseAddress = new Uri(_testConfig.ServiceUri) };
            // act
            var response = await httpClient.GetAsync("/api/values");
            var json = await response.EnsureSuccessStatusCode().Content.ReadAsStringAsync();
            // assert
            Assert.Equal("[\"value1\",\"value2\"]", json);
        }
    }
}
