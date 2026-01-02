using Shared.DDD;
namespace WebApi;

public sealed class PublishSampleDomainEventEndpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/sample-domain-event");
        AllowAnonymous();
        Summary(s => s.Summary = "Publishes a sample domain event via Wolverine");
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var message = new SampleDomainEvent(Guid.NewGuid());
        await Resolve<IMessageBus>().PublishAsync(message);

        Response = new { message.Id };
    }
}
