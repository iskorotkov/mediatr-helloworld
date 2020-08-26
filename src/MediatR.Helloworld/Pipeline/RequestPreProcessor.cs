using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace MediatR.Helloworld.Pipeline
{
    public class RequestPreProcessor : IRequestPreProcessor<Request>
    {
        public Task Process(Request request, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(RequestPreProcessor));
            return Task.CompletedTask;
        }
    }
}