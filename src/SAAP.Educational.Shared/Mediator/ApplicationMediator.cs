using MediatR;
using SAAP.Educational.Shared.CQRS;

namespace SAAP.Educational.Shared.Mediator;

internal sealed class ApplicationMediator(IMediator mediator) : IApplicationMediator
{
    public Task SendAsync(ICommand command, CancellationToken cancellationToken = default)
    {
        return mediator.Send(command, cancellationToken);
    }

    public Task<TResponse> SendAsync<TResponse>(
        ICommand<TResponse> command,
        CancellationToken cancellationToken = default)
    {
        return mediator.Send(command, cancellationToken);
    }

    public Task<TResponse> QueryAsync<TResponse>(
        IQuery<TResponse> query,
        CancellationToken cancellationToken = default)
    {
        return mediator.Send(query, cancellationToken);
    }
}
