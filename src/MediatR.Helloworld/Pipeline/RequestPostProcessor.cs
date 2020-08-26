using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace MediatR.Helloworld.Pipeline
{
    public class RequestPostProcessor : IRequestPostProcessor<Request, string>
    {
        public Task Process(Request request, string response, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(RequestPostProcessor));
            return Task.CompletedTask;
        }
    }
}