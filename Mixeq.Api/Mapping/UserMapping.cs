using Mapster;
using Mixeq.Application;

namespace Mixeq.Api;

public class UserMapping : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateRegisterInputModel, RegisterUserCommand>();
    }
}
