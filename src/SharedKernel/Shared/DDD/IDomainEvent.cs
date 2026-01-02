public interface IDomainEvent
{
    Guid EventGuid => Guid.NewGuid();
    public DateTime OccurredOn => DateTime.UtcNow;
    public string EventType => GetType().AssemblyQualifiedName ?? string.Empty;
}