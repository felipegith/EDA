namespace Mixeq.Domain;

public interface IHasDomainEvent
{
    public IReadOnlyList<IDomainEvent> DomainEvents { get; }

    public void ClearDomainEvents();
}
