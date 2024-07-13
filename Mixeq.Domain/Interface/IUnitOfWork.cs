namespace Mixeq.Domain;

public interface IUnitOfWork
{
    Task<bool> Commit();
}
