using MediatR;

namespace Mixeq.Application;

public record RegisterUserCommand(string Name, string Email) : IRequest<Response>;