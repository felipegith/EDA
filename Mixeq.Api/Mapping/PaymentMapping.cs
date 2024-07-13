using Mapster;
using Mixeq.Application;

namespace Mixeq.Api;

public class PaymentMapping : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreatePaymentInputModel, PaymentCommand>();
    }
}
