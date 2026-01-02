namespace Shared.DDD;

public sealed record SampleDomainEvent(Guid Id) : IDomainEvent;
