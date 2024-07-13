using Mixeq.Domain;

namespace Mixeq.Infrastructure;

public class PaymentRepository : IPaymentRepository
{
    private readonly AppContext _context;

    public PaymentRepository(AppContext context)
    {
        _context = context;
    }

    public async Task<Payment> CreateAsync(Payment payment, CancellationToken cancellationToken)
    {
        try
        {
            await _context.Payments.AddAsync(payment);
            return payment;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
