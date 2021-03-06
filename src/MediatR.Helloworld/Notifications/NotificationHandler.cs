﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Helloworld.Notifications
{
    // Is used as a handler
    public class NotificationHandler : INotificationHandler<Notification>
    {
        public Task Handle(Notification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(NotificationHandler));
            return Task.CompletedTask;
        }
    }
}