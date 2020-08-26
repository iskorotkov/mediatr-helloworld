using System;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace MediatR.Helloworld
{
    internal static class Program
    {
        private static async Task Main()
        {
            var provider = new ServiceCollection()
                .ConfigureServices()
                .BuildServiceProvider();
            using var scope = provider.CreateScope();
            await RunApp(scope.ServiceProvider);
        }

        private static async Task RunApp(IServiceProvider services)
        {
            var mediator = services.GetRequiredService<IMediator>();

            Console.WriteLine("Send request:");
            await mediator.Send(new Request());
        }

        private static ServiceCollection ConfigureServices(this ServiceCollection collection)
        {
            collection.AddMediatR(typeof(Program));
            return collection;
        }
    }
}