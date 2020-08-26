using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Helloworld
{
    public class Notification : INotification
    {
    }

    // Is used as a handler
    public class NotificationHandler : INotificationHandler<Notification>
    {
        public Task Handle(Notification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(NotificationHandler));
            return Task.CompletedTask;
        }
    }

    // Is used as a handler
    public class NotificationHandler2 : INotificationHandler<Notification>
    {
        public Task Handle(Notification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(NotificationHandler2));
            return Task.CompletedTask;
        }
    }
}