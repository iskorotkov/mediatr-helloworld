using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Helloworld.Pipeline
{
    public class PipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Console.WriteLine(nameof(PipelineBehavior<TRequest, TResponse>));
            return await next();
        }
    }
}