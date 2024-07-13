using Mixeq.Domain;

namespace Mixeq.Application;

public record CreatePaymentInputModel(decimal Value, Method Method, Guid UserId);
