using MediatR;
using SAAP.Educational.Shared.CQRS;
using SAAP.Educational.Shared.Mediator;

namespace SAAP.Educational.Application.Mediator;

internal sealed class ApplicationMediator : IApplicationMediator
{
    private readonly IMediator _mediator;

    public ApplicationMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task SendAsync(ICommand command, CancellationToken cancellationToken = default)
    {
        return _mediator.Send(command, cancellationToken);
    }

    public Task<TResponse> SendAsync<TResponse>(
        ICommand<TResponse> command,
        CancellationToken cancellationToken = default)
    {
        return _mediator.Send(command, cancellationToken);
    }

    public Task<TResponse> QueryAsync<TResponse>(
        IQuery<TResponse> query,
        CancellationToken cancellationToken = default)
    {
        return _mediator.Send(query, cancellationToken);
    }
}
