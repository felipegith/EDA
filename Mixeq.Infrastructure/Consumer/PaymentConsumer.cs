using MassTransit;
using Microsoft.Extensions.Logging;
using Mixeq.Domain;

namespace Mixeq.Infrastructure;

public class PaymentConsumer : IConsumer<PaymentCreatedIntegrationEvent>
{
    private readonly ILogger<PaymentCreatedIntegrationEvent> _logger;

    public PaymentConsumer(ILogger<PaymentCreatedIntegrationEvent> logger)
    {
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<PaymentCreatedIntegrationEvent> context)
    {
        _logger.LogInformation($"Consumer messages of queue {context.Message.BuyerEmail} {context.Message.Value}");
        Console.WriteLine($"Consumer messages of queue {context.Message.BuyerEmail} {context.Message.Value}");
    }
}
