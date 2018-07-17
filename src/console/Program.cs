using System.Net;
using System.Threading;
using Sample.Generators;
using Serilog;
using Serilog.Sinks.Udp.TextFormatters;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            ILogger logger = new LoggerConfiguration()
                .WriteTo.Udp(IPAddress.Loopback, 7071, new Log4jTextFormatter())
                .WriteTo.Console()
                .CreateLogger();

            var customerGenerator = new CustomerGenerator();
            var orderGenerator = new OrderGenerator();

            while (true)
            {
                var customer = customerGenerator.Generate();
                var order = orderGenerator.Generate();

                logger.Information("{@customer} placed {@order}", customer, order);

                Thread.Sleep(1000);
            }
        }
    }
}
