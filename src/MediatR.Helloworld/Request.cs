using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Helloworld
{
    public class Request : IRequest<string>
    {
        
    }

    // Is used as a handler
    public class RequestHandler : IRequestHandler<Request, string>
    {
        public Task<string> Handle(Request request, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(RequestHandler));
            return Task.FromResult(nameof(RequestHandler));
        }
    }

    // Is NOT used as a handler
    public class RequestHandler2 : IRequestHandler<Request, string>
    {
        public Task<string> Handle(Request request, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(RequestHandler2));
            return Task.FromResult(nameof(RequestHandler2));
        }
    }
}