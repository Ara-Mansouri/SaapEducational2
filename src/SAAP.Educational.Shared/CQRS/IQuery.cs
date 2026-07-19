using MediatR;

namespace SAAP.Educational.Shared.CQRS;

public interface IQuery<out TResponse> : IRequest<TResponse>;
