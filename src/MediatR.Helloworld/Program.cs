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

            Console.WriteLine("\nSend notification:");
            await mediator.Publish(new Notification());

            Console.WriteLine("\nSend faulty request:");
            await mediator.Send(new FaultyRequest());

            Console.WriteLine("\nSend request with processors:");
            await mediator.Send(new ProcessedRequest());
        }

        private static ServiceCollection ConfigureServices(this ServiceCollection services)
        {
            services.AddMediatR(typeof(Program));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(PipelineBehavior<,>));
            return services;
        }
    }
}