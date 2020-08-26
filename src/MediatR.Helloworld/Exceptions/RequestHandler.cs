using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Helloworld.Exceptions
{
    public class RequestHandler : AsyncRequestHandler<Request>
    {
        protected override Task Handle(Request request, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(RequestHandler));
            throw new ArgumentException("My own exception");
        }
    }
}