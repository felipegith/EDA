namespace Mixeq.Domain;

public interface IUserRepository
{
    void Create(User user, CancellationToken cancellationToken);
}
