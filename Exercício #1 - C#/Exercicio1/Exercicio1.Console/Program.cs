using Exercicio1.Structure.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Exercicio1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IServiceAPI, Exercicio1.ServiceAPI.ServiceAPI>();
            var serviceProvider = collection.BuildServiceProvider();

            var service = new Service(serviceProvider.GetService<IServiceAPI>());

            service.Run();

            Console.ReadKey();
        }
    }
}
