namespace BaseMailSending.Application.Common.Messaging;

using BaseMailSending.Domain.Common;

using MediatR;


public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
