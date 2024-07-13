using System.Net;
using MediatR;
using Mixeq.Domain;

namespace Mixeq.Application;

public class RegisterUserCommandHandle : IRequestHandler<RegisterUserCommand, Response>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _uow;

    public RegisterUserCommandHandle(IUserRepository userRepository, IUnitOfWork uow)
    {
        _userRepository = userRepository;
        _uow = uow;
    }

    public async Task<Response> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var user = new Domain.User(request.Name, request.Email);

        _userRepository.Create(user, cancellationToken);

        await _uow.Commit();

        return new Response(true, "Success", HttpStatusCode.Created, user);
    }
}
