using System;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using MediatR.Helloworld.Notifications;
using MediatR.Helloworld.Pipeline;

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
            await mediator.Send(new Requests.Request());

            Console.WriteLine("\nSend notification:");
            await mediator.Publish(new Notification());

            Console.WriteLine("\nSend faulty request:");
            await mediator.Send(new Exceptions.Request());

            Console.WriteLine("\nSend request with processors:");
            await mediator.Send(new Pipeline.Request());
        }

        private static ServiceCollection ConfigureServices(this ServiceCollection services)
        {
            services.AddMediatR(typeof(Program));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(PipelineBehavior<,>));
            return services;
        }
    }
}