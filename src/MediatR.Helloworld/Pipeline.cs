using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace MediatR.Helloworld
{
    public class ProcessedRequest : IRequest<string>
    {
    }

    public class ProcessedRequestHandler : RequestHandler<ProcessedRequest, string>
    {
        protected override string Handle(ProcessedRequest request)
        {
            Console.WriteLine(nameof(ProcessedRequestHandler));
            return nameof(ProcessedRequestHandler);
        }
    }

    public class RequestPreProcessor : IRequestPreProcessor<ProcessedRequest>
    {
        public Task Process(ProcessedRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(RequestPreProcessor));
            return Task.CompletedTask;
        }
    }

    public class RequestPostProcessor : IRequestPostProcessor<ProcessedRequest, string>
    {
        public Task Process(ProcessedRequest request, string response, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(RequestPostProcessor));
            return Task.CompletedTask;
        }
    }

    public class PipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Console.WriteLine(nameof(PipelineBehavior<TRequest, TResponse>));
            return await next();
        }
    }
}