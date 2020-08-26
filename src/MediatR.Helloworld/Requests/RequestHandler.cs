using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Helloworld.Requests
{
    // Is used as a handler
    public class RequestHandler : IRequestHandler<Request, string>
    {
        public Task<string> Handle(Request request, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(RequestHandler));
            return Task.FromResult(nameof(RequestHandler));
        }
    }
}