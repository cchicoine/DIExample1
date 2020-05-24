using System;
using Microsoft.Extensions.DependencyInjection;

namespace DI_Test1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Setup the container
            var serviceProvider = new ServiceCollection()
                .AddSingleton<AppHost, AppHost>()
               .AddSingleton<ICalculator, Calculator>()

                .BuildServiceProvider();

            // Run our host
            int x=serviceProvider.GetService<AppHost>().Run();
        }
    }
}
