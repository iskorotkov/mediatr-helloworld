using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace MediatR.Helloworld
{
    public class FaultyRequest : IRequest
    {
    }

    public class FaultyRequestHandler : AsyncRequestHandler<FaultyRequest>
    {
        protected override Task Handle(FaultyRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(FaultyRequestHandler));
            throw new ArgumentException("My own exception");
        }
    }

    public class RequestExceptionAction : RequestExceptionAction<FaultyRequest>
    {
        protected override void Execute(FaultyRequest request, Exception exception)
        {
            Console.WriteLine(nameof(RequestExceptionAction));
        }
    }

    public class RequestExceptionAction2 : RequestExceptionAction<FaultyRequest, ArgumentException>
    {
        protected override void Execute(FaultyRequest request, ArgumentException exception)
        {
            Console.WriteLine(nameof(RequestExceptionAction2));
        }
    }

    public class RequestExceptionHandler :
        RequestExceptionHandler<FaultyRequest, Unit, ArgumentException>
    {
        protected override void Handle(FaultyRequest request, ArgumentException exception, RequestExceptionHandlerState<Unit> state)
        {
            Console.WriteLine(nameof(RequestExceptionHandler));
            state.SetHandled(Unit.Value);
        }
    }
}