/**
 * Handler for ProductCreatedDomainEvent.
 *
 * <p>Processes the event after a product is successfully created.
 * Currently logs the event; can be extended for notifications, integrations, etc.</p>
 */

namespace BaseMailSending.Application.Features.V1.Products.EventHandlers;

using Microsoft.Extensions.Logging;

using BaseMailSending.Application.Common.Messaging;
using BaseMailSending.Domain.AggregatesModels.Products.Events;


/// <summary>
/// Handles ProductCreatedDomainEvent published via outbox pattern.
/// </summary>
public sealed class ProductCreatedDomainEventHandler : IDomainEventHandler<ProductCreatedDomainEvent>
{
    private readonly ILogger<ProductCreatedDomainEventHandler> _logger;

    public ProductCreatedDomainEventHandler(ILogger<ProductCreatedDomainEventHandler> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Logs product creation event for tracking and auditing.
    /// </summary>
    public Task Handle(ProductCreatedDomainEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation(
            "[Domain Event] ProductCreated - Name: {ProductName}, Price: {Price:C}, Timestamp: {Timestamp}",
            notification.ProductName,
            notification.Price,
            DateTime.UtcNow);

        return Task.CompletedTask;
    }
}
