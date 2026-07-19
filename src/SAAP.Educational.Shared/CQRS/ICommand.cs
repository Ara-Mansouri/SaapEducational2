using MediatR;

namespace SAAP.Educational.Shared.CQRS;

public interface ICommand : IRequest;

public interface ICommand<out TResponse> : IRequest<TResponse>;
