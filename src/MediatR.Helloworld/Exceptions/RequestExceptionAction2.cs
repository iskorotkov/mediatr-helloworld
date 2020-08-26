using System;
using MediatR.Pipeline;

namespace MediatR.Helloworld.Exceptions
{
    public class RequestExceptionAction2 : RequestExceptionAction<Request, ArgumentException>
    {
        protected override void Execute(Request request, ArgumentException exception)
        {
            Console.WriteLine(nameof(RequestExceptionAction2));
        }
    }
}