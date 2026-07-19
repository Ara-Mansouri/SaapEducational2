using SAAP.Educational.Shared.CQRS;

namespace SAAP.Educational.Shared.Mediator;

public interface IApplicationMediator
{
    Task SendAsync(ICommand command, CancellationToken cancellationToken = default);

    Task<TResponse> SendAsync<TResponse>(
        ICommand<TResponse> command,
        CancellationToken cancellationToken = default);

    Task<TResponse> QueryAsync<TResponse>(
        IQuery<TResponse> query,
        CancellationToken cancellationToken = default);
}
