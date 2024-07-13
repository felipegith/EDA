using FluentValidation;

namespace Mixeq.Application;

public class PaymentCommandValidation : AbstractValidator<PaymentCommand>
{
    public PaymentCommandValidation()
    {
        RuleFor(x => x.Method).NotNull();
        RuleFor(x => x.Value).NotEmpty().GreaterThan(0);
    }
}
