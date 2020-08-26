using System;
using MediatR.Pipeline;

namespace MediatR.Helloworld.Exceptions
{
    public class RequestExceptionAction : RequestExceptionAction<Request>
    {
        protected override void Execute(Request request, Exception exception)
        {
            Console.WriteLine(nameof(RequestExceptionAction));
        }
    }
}