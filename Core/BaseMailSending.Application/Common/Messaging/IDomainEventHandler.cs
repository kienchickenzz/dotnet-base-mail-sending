namespace BaseMailSending.Application.Common.Messaging;

using MediatR;

using BaseMailSending.Domain.Common;


public interface IDomainEventHandler<TEvent> : INotificationHandler<TEvent>
    where TEvent : IDomainEvent
{
}
