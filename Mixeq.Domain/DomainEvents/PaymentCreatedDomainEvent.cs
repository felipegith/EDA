namespace Mixeq.Domain;

public sealed record PaymentCreatedIntegrationEvent(Guid Id, Guid PaymentId, decimal Value, string BuyerEmail) : IDomainEvent;
