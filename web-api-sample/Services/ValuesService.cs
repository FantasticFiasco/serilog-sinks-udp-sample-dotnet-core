using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Sample.Services
{
    public class ValuesService
    {
        private readonly List<string> values;
        private readonly ILogger<ValuesService> logger;

        public ValuesService(ILogger<ValuesService> logger)
        {
            this.logger = logger;

            values = new List<string>
            {
                "value1",
                "value2"
            };
        }

        public void Add(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            logger.LogInformation("Adding {value}", value);

            values.Add(value);
        }

        public string[] GetAll()
        {
            logger.LogInformation("Get all values");;

            return values.ToArray();
        }

        public void Remove(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            logger.LogInformation("Removing {value}", value);

            values.Remove(value);
        }
    }
}
