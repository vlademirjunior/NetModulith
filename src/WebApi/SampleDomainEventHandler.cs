using Shared.DDD;

namespace WebApi;

public sealed class SampleDomainEventHandler
{
    public static void Handle(SampleDomainEvent message)
    {
        // Example handler: put side-effects here (logging, projections, integrations, etc.)
        Console.WriteLine($"Handled SampleDomainEvent: {message.Id}");
    }
}
