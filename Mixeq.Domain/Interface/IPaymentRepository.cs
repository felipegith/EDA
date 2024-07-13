namespace Mixeq.Domain;

public interface IPaymentRepository
{
    Task<Payment> CreateAsync(Payment payment, CancellationToken cancellationToken);
}
