using System;
using MediatR.Pipeline;

namespace MediatR.Helloworld.Exceptions
{
    public class RequestExceptionHandler :
        RequestExceptionHandler<Request, Unit, ArgumentException>
    {
        protected override void Handle(Request request, ArgumentException exception, RequestExceptionHandlerState<Unit> state)
        {
            Console.WriteLine(nameof(RequestExceptionHandler));
            state.SetHandled(Unit.Value);
        }
    }
}