using MediatR;
using Mixeq.Domain;

namespace Mixeq.Application;

public record PaymentCommand(decimal Value, Method Method, Guid UserId) : IRequest<Response>;
