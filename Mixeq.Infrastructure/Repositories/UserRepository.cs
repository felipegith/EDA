using Mixeq.Domain;

namespace Mixeq.Infrastructure;

public class UserRepository : IUserRepository
{
    private readonly AppContext _context;

    public UserRepository(AppContext context)
    {
        _context = context;
    }

    public void Create(User user, CancellationToken cancellationToken)
    {
        try
        {
            _context.Users.Add(user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
