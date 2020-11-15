using System.Linq;
using System.Collections.Generic;

namespace Example.Service.Services
{
    public class ValuesService
    {
        public IEnumerable<string> GetValues() => new string[] { "value1", "value2" };

        public string GetValue() => GetValues().First();
    }
}
