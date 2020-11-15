using System;
using Microsoft.Extensions.Configuration;

namespace Example.Service.ComponentTests
{
    public class ComponentTestFixture : IDisposable
    {
        public ComponentTestConfig TestConfig { get; }

        public ComponentTestFixture()
        {
            TestConfig = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .Build()
                .GetSection("ComponentTests")
                .Get<ComponentTestConfig>();
        }

        public void Dispose()
        {
        }
    }
}
