using System;

namespace MediatR.Helloworld.Pipeline
{
    public class RequestHandler : RequestHandler<Request, string>
    {
        protected override string Handle(Request request)
        {
            Console.WriteLine(nameof(RequestHandler));
            return nameof(RequestHandler);
        }
    }
}